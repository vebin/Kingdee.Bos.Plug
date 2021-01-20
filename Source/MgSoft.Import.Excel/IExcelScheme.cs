using MgSoft.Import.Excel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public interface IExcelScheme : IScheme
    {
        AggregateExcelMessage Import(FileExcelTaskType fileExcelTaskType);
    }
}
