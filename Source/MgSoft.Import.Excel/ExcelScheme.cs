using Autofac;
using MgSoft.Import.Excel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MgSoft.Import.Excel
{
    public abstract class ExcelScheme : Scheme, IExcelScheme
    {
        private ILifetimeScope lifetimeScope;

        protected SortedList<int, string> orderTaskManager { get; set; }
        private IMgLog log=new MgSoft.Log.NullMgLog();

        protected ExcelScheme(ILifetimeScope lifetimeScope)
        {
            this.lifetimeScope = lifetimeScope;
            IMgLogger mgLogger = lifetimeScope.Resolve<IMgLogger>();
            if (mgLogger != null) log = mgLogger.CreateLog();
        }

        public abstract List<FileExcelTaskTypeInfo> Match(string filePath);

        public AggregateExcelMessage InitAndCheck(List<FileExcelTaskTypeInfo> fileExcelTaskTypes)
        {
            AggregateExcelMessage result = new AggregateExcelMessage();
            foreach (var fileExcelTaskType in fileExcelTaskTypes)
            {
                AggregateExcelMessage aggregateExcelMessage = new AggregateExcelMessage();
                TaskManagerInfoArg taskManagerInfoArg = new TaskManagerInfoArg(null, fileExcelTaskType, aggregateExcelMessage);
                var socpe = lifetimeScope.BeginLifetimeScope();
                var excelTaskManager = socpe.ResolveNamed<IExcelTaskManager>(taskManagerInfoArg.FileExcelTaskTypeInfo.TaskManagerName);

                fileExcelTaskType.SetTaskManagerInstance(excelTaskManager);
                excelTaskManager.InitAndCheck(taskManagerInfoArg);
                result.Add(aggregateExcelMessage);
            }
            //把错误日志写入到日志
            writeExceptionLog(result);
            return result;
        }

        private void writeExceptionLog(AggregateExcelMessage result)
        {
            var exceptionMessage = result.ExcelMessages.Where(p => p.MessageType == ExcelMessageType.Exception).ToList();
            foreach (var message in exceptionMessage)
            {
                log.Error(message.Message+"\r\n"+message.Detail);
            }
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
            //var excelTaskManager = lifetimeScope.ResolveNamed<IExcelTaskManager>(fileExcelTaskType.TaskManagerName);
            var excelTaskManager = fileExcelTaskType.TaskManager;
            TaskManagerInfoArg taskManagerInfoArg = new TaskManagerInfoArg(excelTaskManager.MgExcel, fileExcelTaskType, aggregateExcelMessage);
            excelTaskManager.Do(taskManagerInfoArg);
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
