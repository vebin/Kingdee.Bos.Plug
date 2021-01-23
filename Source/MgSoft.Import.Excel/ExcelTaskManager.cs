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

        protected string ExcelFilePath { get; private set; }

        public abstract void Check(ref AggregateExcelMessage aggregateExcelMessage);

        public abstract void Do(ref AggregateExcelMessage aggregateExcelMessage);

        public virtual void SetExcelFilePath(string excelFilePath)
        {
            this.ExcelFilePath = excelFilePath;
        }
    }
}
