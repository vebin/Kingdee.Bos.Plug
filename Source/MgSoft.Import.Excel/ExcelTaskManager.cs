using MgSoft.Import.Excel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public abstract class ExcelTaskManager : Scheme, IExcelTaskManager
    {
        public abstract AggregateExcelMessage Import(FileExcelTaskType fileExcelTaskType);
    }
}
