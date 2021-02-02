using MgSoft.Excel.Model.Dto;
using MgSoft.Excel.Model.Excel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public class ExcelDto: IExcelDto
    {
        public MgRow Row { get; set; }

        void IExcelDto.SetRow(MgRow mgRow)
        {
            Row = mgRow;
        }
    }
}
