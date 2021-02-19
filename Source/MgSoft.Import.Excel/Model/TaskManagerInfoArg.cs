using MgSoft.Excel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel.Model
{
    public class TaskManagerInfoArg : ITaskManagerInfoArg
    {
        public MgExcel MgExcel { get; private set; }

        public FileExcelTaskTypeInfo FileExcelTaskTypeInfo { get; private set; }

        public AggregateExcelMessage AggregateExcelMessage { get; private set; }

        public TaskManagerInfoArg(MgExcel mgExcel, FileExcelTaskTypeInfo fileExcelTaskTypeInfo, AggregateExcelMessage aggregateExcelMessage)
        {
            this.MgExcel = mgExcel;
            this.FileExcelTaskTypeInfo = fileExcelTaskTypeInfo;
            this.AggregateExcelMessage = aggregateExcelMessage;
        }
        public TaskManagerInfoArg(FileExcelTaskTypeInfo fileExcelTaskTypeInfo, AggregateExcelMessage aggregateExcelMessage)
        {
            this.FileExcelTaskTypeInfo = fileExcelTaskTypeInfo;
            this.AggregateExcelMessage = aggregateExcelMessage;
        }

        void ITaskManagerInfoArg.SetMgExcel(MgExcel mgExcel)
        {
            MgExcel = mgExcel;
        }
    }
}
