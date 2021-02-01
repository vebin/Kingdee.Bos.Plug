using MgSoft.Excel;
using MgSoft.Excel.Model.Excel;
using MgSoft.Import.Excel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public abstract class ExcelTask<TDto> : IExcelTask<TDto>
    {
        /// <summary>
        /// 重点检验表格原始数据正确性，重点在校验表格本身
        /// 例如：
        /// 1.表格数据两列不能同时填值
        /// 2.表格中有两行数据重复
        /// </summary>
        /// <param name="mgRow"></param>
        /// <remarks>
        /// author:catdemon
        /// date:2021-2-1
        /// </remarks>
        /// <param name="taskManagerInfoArg"></param>
        public abstract void CheckMgRow(MgRow mgRow, TaskManagerInfoArg taskManagerInfoArg);

        /// <summary>
        /// 重点校验业务正确性，重点在校验与业务系统的逻辑
        /// 例如：
        /// 1.客户编码在系统中不存在
        /// 2.数据在数据库中已经存在
        /// </summary>
        /// <remarks>
        /// author:catdemon
        /// date:2021-2-1
        /// </remarks>
        /// <param name="dto"></param>
        /// <param name="taskManagerInfoArg"></param>
        public abstract void CheckDto(TDto dto, TaskManagerInfoArg taskManagerInfoArg);

        public abstract void Do(TDto dto, TaskManagerInfoArg taskManagerInfoArg);
    }
}
