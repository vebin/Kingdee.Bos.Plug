using MgSoft.Excel;
using MgSoft.Import.Excel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public abstract class ExcelTask<TDto> : IExcelTask<TDto>
    {
        public abstract void Do(TDto dto, AggregateExcelMessage aggregateExcelMessage, TaskManagerInfoArg taskManagerInfoArg);
    }
}
