using MgSoft.Import.Excel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public interface IExcelScheme : IScheme
    {
        AggregateExcelMessage Check(List<FileExcelTaskTypeInfo> fileExcelTaskType);

        AggregateExcelMessage Import(List<FileExcelTaskTypeInfo> fileExcelTaskType);

        FileExcelTaskTypeInfo Match(string filePath);
        List<FileExcelTaskTypeInfo> Match(List<string> filePaths);
    }
}
