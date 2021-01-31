using Autofac;
using MgSoft.Import.Excel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public abstract class ExcelScheme : Scheme, IExcelScheme
    {
        private ILifetimeScope lifetimeScope;

        protected SortedList<int, string> orderTaskManager { get; set; }

        protected ExcelScheme(ILifetimeScope lifetimeScope)
        {
            this.lifetimeScope = lifetimeScope;
        }

        public abstract List<FileExcelTaskTypeInfo> Match(string filePath);

        public AggregateExcelMessage InitAndCheck(List<FileExcelTaskTypeInfo> fileExcelTaskTypes)
        {
            AggregateExcelMessage aggregateExcelMessage = new AggregateExcelMessage();
            foreach (var fileExcelTaskType in fileExcelTaskTypes)
            {
                TaskManagerInfoArg taskManagerInfoArg = new TaskManagerInfoArg(null, fileExcelTaskType, aggregateExcelMessage);
                check(taskManagerInfoArg);
            }
            return aggregateExcelMessage;
        }

        private void check(TaskManagerInfoArg taskManagerInfoArg)
        {
            var excelTaskManager = lifetimeScope.ResolveNamed<IExcelTaskManager>(taskManagerInfoArg.FileExcelTaskTypeInfo.TaskManagerName);
            excelTaskManager.InitAndCheck(taskManagerInfoArg);
        }

        public virtual AggregateExcelMessage Import(List<FileExcelTaskTypeInfo> fileExcelTaskTypes)
        {
            AggregateExcelMessage aggregateExcelMessage = new AggregateExcelMessage();

            foreach (var fileExcelTaskType in fileExcelTaskTypes)
            {
                import(fileExcelTaskType, aggregateExcelMessage);
            }
            return aggregateExcelMessage;
        }

        private void import(FileExcelTaskTypeInfo fileExcelTaskType, AggregateExcelMessage aggregateExcelMessage)
        {
            var excelTaskManager = lifetimeScope.ResolveNamed<IExcelTaskManager>(fileExcelTaskType.TaskManagerName);
            excelTaskManager.Do(aggregateExcelMessage);
        }

        public List<FileExcelTaskTypeInfo> Match(List<string> filePaths)
        {
            List<FileExcelTaskTypeInfo> result = new List<FileExcelTaskTypeInfo>();
            foreach (var filePath in filePaths)
            {
                var fileExcelTaskTypes = Match(filePath);
                if (fileExcelTaskTypes.Count != 0) result.AddRange(fileExcelTaskTypes);
            }
            return result;
        }

        public abstract void DoTaskManagers(List<FileExcelTaskTypeInfo> fileExcelTaskTypes, AggregateExcelMessage aggregateExcelMessage);
    }
}
