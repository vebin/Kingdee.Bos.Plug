using MgSoft.Import.Excel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public abstract class ExcelScheme: Scheme, IExcelScheme
    {
        public abstract AggregateExcelMessage Import(Import.Excel.Model.FileExcelTaskType fileExcelTaskType);
    }
}
