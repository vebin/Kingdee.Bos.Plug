using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel.Model
{
    public class FileExcelTaskTypeInfo : ExcelTaskTypeInfo, IProcessInfo
    {
        private int rowNumber;
        private int totalRowCount;

        public FileExcelTaskTypeInfo(ExcelTaskTypeInfo excelTaskTypeInfo)
        {
            TaskManagerName = excelTaskTypeInfo.TaskManagerName;
            TaskManagerTitle = excelTaskTypeInfo.TaskManagerTitle;
            TaskManagerDescribe = excelTaskTypeInfo.TaskManagerDescribe;
            ComponentName = excelTaskTypeInfo.ComponentName;
            ComponentTitle = excelTaskTypeInfo.ComponentTitle;
            ComponentDescribe = excelTaskTypeInfo.ComponentDescribe;
        }

        public FileExcelTaskTypeInfo()
        {
        }

        public Guid Id { get; private set; } = new Guid();

        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath { get; set; }

        public int GetSyncRowNumber()
        {
            return rowNumber;
        }

        public int GetTotalRowCount()
        {
            return totalRowCount;
        }

        public double GetPercent()
        {
            return (double)rowNumber / (double)totalRowCount;
        }

        void IProcessInfo.SetProcessRow(int rowSetp)
        {
            if (!checkSetProcessRow(rowSetp)) return;
            rowNumber += rowSetp;
        }

        private bool checkSetProcessRow(int rowSetp)
        {
            if (rowNumber == totalRowCount) return false;
            if (rowSetp <= 0) throw new MgException("rowSet必须大于0");
            if (totalRowCount == 0) throw new MgException("需要调用SetProcessTotalRow初始化");

            return true;
        }

        void IProcessInfo.SetProcessTotalRow(int totleRow)
        {
            rowNumber = 0;
            totalRowCount = totleRow;
        }
    }
}
