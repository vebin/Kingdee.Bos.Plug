﻿using MgSoft.Excel;
using MgSoft.Import.Excel.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Autofac;
//using MgSoft.Log;
using System.Threading;
using MgSoft.Log;

namespace MgSoft.Import.Excel
{
    public abstract class ExcelTaskManager<TDto> : TaskManager, IExcelTaskManager where TDto : ExcelDto, new()
    {
        private const int maxThreaderCount = 40;

        private readonly ILifetimeScope lifetimeScope;

        /// <summary>
        /// 表格转换为Dto列表
        /// </summary>
        protected List<TDto> Dtos { get; set; }

        /// <summary>
        /// 实现ExcelTaskManager的类型名称，用于名称注入
        /// </summary>
        public virtual string Name => this.GetType().FullName;

        /// <summary>
        /// TaskManager中文标题
        /// </summary>
        public abstract string Title { get; }

        /// <summary>
        /// TaskManager的描述说明
        /// </summary>
        public abstract string Describe { get; }

        ///// <summary>
        ///// Excel表格文件路径
        ///// </summary>
        //protected string ExcelFilePath { get; private set; }

        /// <summary>
        /// 具体实现的ExcelTask
        /// </summary>
        protected abstract IExcelTask<TDto> ExcelTask { get; }

        /// <summary>
        /// Excel读取数据的Dao
        /// </summary>
        protected abstract IExcelDao ExcelDao { get; }

        /// <summary>
        /// 读取到的Excel
        /// </summary>
        public MgExcel MgExcel { get; private set; }

        protected FileExcelTaskTypeInfo FileExcelTaskTypeInfo { get; private set; }

        protected IMgLog log { get; private set; } = new NullMgLog();

        protected ExcelTaskManager(Autofac.ILifetimeScope lifetimeScope)
        {
            this.lifetimeScope = lifetimeScope;
            IMgLogger mgLogger;
            lifetimeScope.TryResolve<IMgLogger>(out mgLogger);
            if (mgLogger != null) log = mgLogger.CreateLog();
        }


        /// <summary>
        /// 初始化表格，并对数据进行校验
        /// </summary>
        /// <param name="aggregateExcelMessage"></param>
        public virtual void InitAndCheck(TaskManagerInfoArg taskManagerInfoArg)
        {
            try
            {
                AggregateExcelMessage aggregateExcelMessage = taskManagerInfoArg.AggregateExcelMessage;

                BeforeInit(taskManagerInfoArg);
                if (hasErrorOrException(aggregateExcelMessage)) return;

                initCheck(taskManagerInfoArg);
                if (hasErrorOrException(aggregateExcelMessage)) return;

                initMgExcel(taskManagerInfoArg);
                if (hasErrorOrException(aggregateExcelMessage)) return;

                AfterInit(taskManagerInfoArg);
                if (hasErrorOrException(aggregateExcelMessage)) return;

                CheckMgRow(taskManagerInfoArg);
                if (hasErrorOrException(aggregateExcelMessage)) return;

                Dtos = ConvertToDto(taskManagerInfoArg);
                if (hasErrorOrException(aggregateExcelMessage)) return;

                CheckDto(taskManagerInfoArg);
            }
            catch (AggregateErrorException aggregateErrorException)
            {
                //Excel表格校验失败
                taskManagerInfoArg.AggregateExcelMessage.AddRange(aggregateErrorException.ErrorMessages, ExcelMessageType.Exception, FileExcelTaskTypeInfo);
            }
            catch (MgException mgException)
            {
                log.Error(mgException.Message);
                taskManagerInfoArg.AggregateExcelMessage.Add(new ExcelMessage(mgException.Message, "", ExcelMessageType.Exception, FileExcelTaskTypeInfo));
            }
            catch (Exception exception)
            {
                log.Error(exception.Message + "\n" + exception.StackTrace);
                taskManagerInfoArg.AggregateExcelMessage.Add(exception.Message, exception.StackTrace, ExcelMessageType.Exception, FileExcelTaskTypeInfo);
            }
        }

        private bool hasErrorOrException(AggregateExcelMessage aggregateExcelMessage)
        {
            return aggregateExcelMessage.HasError() || aggregateExcelMessage.HasException();
        }

        /// <summary>
        /// 导入数据
        /// </summary>
        /// <param name="taskManagerInfoArg"></param>
        public virtual void Do(TaskManagerInfoArg taskManagerInfoArg)
        {
            var processInfo = (FileExcelTaskTypeInfo as IProcessInfo);
            processInfo.SetProcessTotalRow(Dtos.Count);
            ThreadPool.SetMaxThreads(maxThreaderCount, maxThreaderCount);
            foreach (var dto in Dtos)
            {
                try
                {
                    ExcelTask.Do(dto, taskManagerInfoArg);
                }
                catch (MgExcelException mgExcelException)
                {
                    taskManagerInfoArg.AggregateExcelMessage.Add(dto.Row.RowIndex, mgExcelException.ColumnIndex, mgExcelException.Message, "", ExcelMessageType.Exception, FileExcelTaskTypeInfo);
                }
                catch (MgException mgException)
                {
                    taskManagerInfoArg.AggregateExcelMessage.Add(dto.Row.RowIndex, 0, mgException.Message, "", ExcelMessageType.Exception, FileExcelTaskTypeInfo);
                }
                catch (Exception exception)
                {
                    log.Error(exception.Message + "\n" + exception.StackTrace);
                    taskManagerInfoArg.AggregateExcelMessage.Add(dto.Row?.RowIndex, 0, exception.Message, exception.StackTrace, ExcelMessageType.Exception, FileExcelTaskTypeInfo);
                }
                finally
                {
                    processInfo.SetProcessRow();
                }
            }
        }

        #region 可重载方法
        /// <summary>
        /// 自定义校验
        /// </summary>
        /// <param name="aggregateExcelMessage"></param>
        protected virtual void CheckDto(TaskManagerInfoArg taskManagerInfoArg)
        {
            foreach (var dto in Dtos)
            {
                ExcelTask.CheckBusiness(dto, taskManagerInfoArg);
            }
        }

        /// <summary>
        /// 初始化之前
        /// </summary>
        protected virtual void AfterInit(TaskManagerInfoArg taskManagerInfoArg)
        {
        }

        /// <summary>
        /// 初始化之后
        /// </summary>
        protected virtual void BeforeInit(TaskManagerInfoArg taskManagerInfoArg)
        {
        }

        protected void CheckMgRow(TaskManagerInfoArg taskManagerInfoArg)
        {
            if(!this.MgExcel.MgSheet.IsHasRow())
            {
                taskManagerInfoArg.AggregateExcelMessage.Add(new ExcelMessage("表格没有可以导入的数据", "", ExcelMessageType.Error, taskManagerInfoArg.FileExcelTaskTypeInfo));
            }

            var processInfo = ((IProcessInfo)taskManagerInfoArg.FileExcelTaskTypeInfo);
            processInfo.SetProcessTotalRow(this.MgExcel.MgSheet.GetTotleRow());
            for (int rowIndex = this.MgExcel.MgSheet.StartRowIndex; rowIndex <= this.MgExcel.MgSheet.MaxRowIndex; rowIndex++)
            {
                try
                {
                    var row = MgExcel.MgSheet.GetRow(rowIndex);
                    ExcelTask.CheckMgRow(row, taskManagerInfoArg);
                }
                finally
                {
                    processInfo.SetProcessRow();
                }
            }
        }

        protected TaskManagerInfoArg GetTaskManagerInfoArg(AggregateExcelMessage aggregateExcelMessage)
        {
            return new TaskManagerInfoArg(MgExcel, FileExcelTaskTypeInfo, aggregateExcelMessage);
        }

        /// <summary>
        /// 把Excel数据数据转换为Dto，默认转换规则为一行数据转换为一个Dto，如需多行数据转换为一个Dto请自行重载
        /// </summary>
        /// <returns></returns>
        protected virtual List<TDto> ConvertToDto(TaskManagerInfoArg taskManagerInfoArg)
        {
            List<TDto> result = new List<TDto>();
            var startRowIndex = MgExcel.MgSheet.StartRowIndex;
            var maxRowIndex = MgExcel.MgSheet.MaxRowIndex;
            for (var rowIndex = startRowIndex; rowIndex <= maxRowIndex; rowIndex++)
            {
                var row = MgExcel.MgSheet.GetRow(rowIndex);
                result.Add(row.ToObject<TDto>());
            }

            return result;
        }
        #endregion

        #region 私有方案

        private void initMgExcel(TaskManagerInfoArg taskManagerInfoArg)
        {
            MgExcel = ExcelDao.GetExcel(FileExcelTaskTypeInfo.FilePath);
            (taskManagerInfoArg as ITaskManagerInfoArg).SetMgExcel(MgExcel);//调用显式实现接口给MgExcel赋值
        }

        private void initCheck(TaskManagerInfoArg taskManagerInfoArg)
        {
            this.FileExcelTaskTypeInfo = taskManagerInfoArg.FileExcelTaskTypeInfo;

            if (string.IsNullOrEmpty(FileExcelTaskTypeInfo.FilePath))
            {
                throw new MgException("没有设置文件名称");
            }

            if (!File.Exists(FileExcelTaskTypeInfo.FilePath))
            {
                throw new MgException($"文件不存在或已删除，{FileExcelTaskTypeInfo.FilePath}");
            }
        }


        #endregion
    }
}
