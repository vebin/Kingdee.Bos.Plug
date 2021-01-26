using MgSoft.Excel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel.Model
{
    public class TaskManagerInfoArg
    {
        public MgExcel MgExcel { get; private set; }

        public FileExcelTaskTypeInfo FileExcelTaskTypeInfo { get; private set; }

        public TaskManagerInfoArg(MgExcel mgExcel, FileExcelTaskTypeInfo fileExcelTaskTypeInfo)
        {
            this.MgExcel = mgExcel;
            this.FileExcelTaskTypeInfo = fileExcelTaskTypeInfo;
        }
    }
}
