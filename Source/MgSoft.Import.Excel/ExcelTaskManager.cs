using MgSoft.Excel;
using MgSoft.Import.Excel.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MgSoft.Import.Excel
{
    public abstract class ExcelTaskManager<TDto> : TaskManager, IExcelTaskManager where TDto : ExcelDto, new()
    {
        protected List<TDto> Dtos { get; set; }

        public virtual string Name => this.GetType().FullName;

        public abstract string Title { get; }

        public abstract string Describe { get; }

        protected string ExcelFilePath { get; private set; }

        protected abstract IExcelTask<TDto> ExcelTask { get; }

        protected abstract IExcelDao ExcelDao { get; }

        protected MgExcel MgExcel { get; set; }

        public virtual void InitAndCheck(AggregateExcelMessage aggregateExcelMessage)
        {
            try
            {
                BeforeInit();
                initCheck();
                initMgExcel();
                AfterInit();
                Check(aggregateExcelMessage);
                Dtos = ConvertToDto();
            }
            catch (AggregateErrorException aggregateErrorException)
            {
                //Excel表格校验失败
                aggregateExcelMessage.AddRange(aggregateErrorException.ErrorMessages);
            }
            catch (MgException mgException)
            {
                aggregateExcelMessage.Add(new ExcelMessage(mgException.Message, ExcelMessageType.Error));
            }
        }

        protected virtual void AfterInit()
        {
        }

        protected virtual void BeforeInit()
        {
        }

        protected virtual void Check(AggregateExcelMessage aggregateExcelMessage)
        {
        }


        public virtual void Do(AggregateExcelMessage aggregateExcelMessage)
        {
            Dtos = ConvertToDto();
            foreach (var dto in Dtos)
            {
                ExcelTask.Do(dto, MgExcel, aggregateExcelMessage);
            }
        }

        public virtual void SetExcelFilePath(string excelFilePath)
        {
            this.ExcelFilePath = excelFilePath;
        }

        public virtual List<TDto> ConvertToDto()
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

        private void initMgExcel()
        {
            MgExcel = ExcelDao.GetExcel(ExcelFilePath);
        }

        private void initCheck()
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
