using MgSoft.Import.Excel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public abstract class ExcelTaskManager : TaskManager, IExcelTaskManager
    {
        public abstract string Name { get; }

        public abstract string Title { get; }

        public abstract string Describe { get; }

        public abstract void Do(ref AggregateExcelMessage aggregateExcelMessage);

        public void SetExcelFilePath(string excelFilePath)
        {
            throw new NotImplementedException();
        }
    }
}
