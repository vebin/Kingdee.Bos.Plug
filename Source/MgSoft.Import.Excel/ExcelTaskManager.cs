using MgSoft.Excel;
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

        /// <summary>
        /// Excel表格文件路径
        /// </summary>
        protected string ExcelFilePath { get; private set; }

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
        protected MgExcel MgExcel { get; set; }

        protected FileExcelTaskTypeInfo FileExcelTaskTypeInfo { get; private set; }

        protected IMgLog log { get; private set; }

        protected ExcelTaskManager(Autofac.ILifetimeScope lifetimeScope)
        {
            this.lifetimeScope = lifetimeScope;
            IMgLogger mgLogger;
            lifetimeScope.TryResolve<IMgLogger>(out mgLogger);
            if (mgLogger == null)
            {
                log = new NullMgLog();
            }
            else
            {
                log = mgLogger.CreateLog();
            }
        }


        /// <summary>
        /// 初始化表格，并对数据进行校验
        /// </summary>
        /// <param name="aggregateExcelMessage"></param>
        public virtual void InitAndCheck(TaskManagerInfoArg taskManagerInfoArg)
        {
            try
            {
                BeforeInit(taskManagerInfoArg);
                initCheck(taskManagerInfoArg);
                initMgExcel(taskManagerInfoArg);
                AfterInit(taskManagerInfoArg);
                Check(taskManagerInfoArg);
                Dtos = ConvertToDto(taskManagerInfoArg);
            }
            catch (AggregateErrorException aggregateErrorException)
            {
                //Excel表格校验失败
                taskManagerInfoArg.AggregateExcelMessage.AddRange(aggregateErrorException.ErrorMessages, ExcelMessageType.Error, FileExcelTaskTypeInfo);
            }
            catch (MgException mgException)
            {
                taskManagerInfoArg.AggregateExcelMessage.Add(new ExcelMessage(mgException.Message, "", ExcelMessageType.Error, FileExcelTaskTypeInfo));
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

        /// <summary>
        /// 自定义校验
        /// </summary>
        /// <param name="aggregateExcelMessage"></param>
        protected virtual void Check(TaskManagerInfoArg taskManagerInfoArg)
        {
        }

        /// <summary>
        /// 导入数据
        /// </summary>
        /// <param name="aggregateExcelMessage"></param>
        public virtual void Do(AggregateExcelMessage aggregateExcelMessage)
        {
            var processInfo = (FileExcelTaskTypeInfo as IProcessInfo);
            processInfo.SetProcessTotalRow(Dtos.Count);
            ThreadPool.SetMaxThreads(maxThreaderCount, maxThreaderCount);
            foreach (var dto in Dtos)
            {
                try
                {
                    ExcelTask.Do(dto, aggregateExcelMessage, GetTaskManagerInfoArg(aggregateExcelMessage));
                }
                catch (MgExcelException mgExcelException)
                {
                    aggregateExcelMessage.Add(dto.Row.RowIndex, mgExcelException.ColumnIndex, mgExcelException.Message, "", ExcelMessageType.Error, FileExcelTaskTypeInfo);
                }
                catch (MgException mgException)
                {
                    aggregateExcelMessage.Add(dto.Row.RowIndex, 0, mgException.Message, "", ExcelMessageType.Error, FileExcelTaskTypeInfo);
                }
                catch (Exception exception)
                {
                    log.Error(exception.Message + "\n" + exception.StackTrace);
                    aggregateExcelMessage.Add(dto.Row.RowIndex, 0, exception.Message, exception.StackTrace, ExcelMessageType.Error, FileExcelTaskTypeInfo);
                } 
                finally
                {
                    processInfo.SetProcessRow();
                }
            } 
        }

        protected TaskManagerInfoArg GetTaskManagerInfoArg(AggregateExcelMessage aggregateExcelMessage)
        {
            return new TaskManagerInfoArg(MgExcel, FileExcelTaskTypeInfo,aggregateExcelMessage);
        }

        /// <summary>
        /// 把Excel数据数据转换为Dto
        /// </summary>
        /// <returns></returns>
        public virtual List<TDto> ConvertToDto(TaskManagerInfoArg taskManagerInfoArg)
        {
            List<TDto> result = new List<TDto>();
            var startRowIndex = MgExcel.MgSheet.StartRowIndex;
            var maxRowIndex = MgExcel.MgSheet.MaxRowIndex;
            for (var rowIndex = startRowIndex; rowIndex < maxRowIndex; rowIndex++)
            {
                var row = MgExcel.MgSheet.GetRow(rowIndex);
                result.Add(row.ToObject<TDto>());
            }

            return result;
        }

        private void initMgExcel(TaskManagerInfoArg taskManagerInfoArg)
        {
            MgExcel = ExcelDao.GetExcel(ExcelFilePath);
            (taskManagerInfoArg as ITaskManagerInfoArg).SetMgExcel(MgExcel);//调用显式实现接口给MgExcel赋值
        }

        private void initCheck(TaskManagerInfoArg taskManagerInfoArg)
        {
            if (string.IsNullOrEmpty(ExcelFilePath))
            {
                throw new MgException("没有设置文件名称");
            }

            if (!File.Exists(ExcelFilePath))
            {
                throw new MgException($"文件不存在或已删除，{ExcelFilePath}");
            }
        }
    }
}
