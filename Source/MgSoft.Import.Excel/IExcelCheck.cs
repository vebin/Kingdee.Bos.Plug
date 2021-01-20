using MgSoft.Excel;
using MgSoft.Import.Excel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    /// <summary>
    /// 数据校验接口
    /// </summary>
    public interface IExcelCheck
    {
        List<ExcelMessage> Check(MgExcel mgExcel);
    }
}
