using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel.Model
{
    public class ExcelTaskTypeInfo
    {
        public ExcelTaskTypeInfo()
        {
        }
            

        /// <summary>
        /// 导入管理任务方案名称
        /// </summary>
        public string TaskManagerName { get; set; }

        public string TaskManagerTitle { get; set; }
        public string TaskManagerDescribe { get; set; }

        public IExcelTaskManager TaskManager { get;private set; }

        /// <summary>
        /// 导入组件名称
        /// </summary>
        public string ComponentName { get; set; }
        public string ComponentTitle { get; set; }

        public string ComponentDescribe { get; set; }

        public void SetTaskManagerInstance(IExcelTaskManager taskManagerInstance)
        {
            TaskManager = taskManagerInstance;
        }
    }
}
