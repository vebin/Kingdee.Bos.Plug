using MgSoft.Excel;
using MgSoft.Excel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public abstract class ExcelDao : IExcelDao
    {
        protected abstract TemplateConfig TemplateConfigService { get; }

        public MgExcel GetExcel(string filePath)
        {
            MgExcel mgExcel = new MgExcel();
            var errorMessages = mgExcel.ReadAsync(filePath, TemplateConfigService).GetAwaiter().GetResult();
            if (errorMessages.Count > 0)
            {
                throw new AggregateErrorException("数据校验错误", errorMessages);
            }
            return mgExcel;
        }
    }
}
