using MgSoft.Import.Excel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public interface IExcelScheme : IScheme
    {
        AggregateExcelMessage Check(List<FileExcelTaskType> fileExcelTaskType);

        AggregateExcelMessage Import(List<FileExcelTaskType> fileExcelTaskType);

        FileExcelTaskType Match(string filePath);
        List<FileExcelTaskType> Match(List<string> filePaths);
    }
}
