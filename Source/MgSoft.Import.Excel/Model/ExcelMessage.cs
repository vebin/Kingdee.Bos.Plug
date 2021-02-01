using MgSoft.Excel.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel.Model
{
    public class ExcelMessage
    {
        public ExcelMessageType MessageType { get; }

        public string Message { get; }

        public string Detail { get; }

        public FileExcelTaskTypeInfo FileExcelTaskTypeInfo { get; }

        public ExcelMessage(string message, string detail = "", ExcelMessageType excelMessageType = ExcelMessageType.Info, FileExcelTaskTypeInfo fileExcelTaskTypeInfo = null)
            : this(rowIndex: 0, columnIndex: 0, message: message, detail: detail, fileExcelTaskTypeInfo: fileExcelTaskTypeInfo, excelMessageType: excelMessageType)
        {
            this.FileExcelTaskTypeInfo = fileExcelTaskTypeInfo;
        }

        public ExcelMessage(int rowIndex, int columnIndex, string message = "", string detail = "", FileExcelTaskTypeInfo fileExcelTaskTypeInfo = null, ExcelMessageType excelMessageType = ExcelMessageType.Info)
        {
            RowIndex = rowIndex;
            ColumnIndex = columnIndex;
            MessageType = excelMessageType;
            Message = message;
            Detail = detail;
            this.FileExcelTaskTypeInfo = fileExcelTaskTypeInfo;
        }
        public ExcelMessage(int? rowIndex, int? columnIndex, string message = "", string detail = "", FileExcelTaskTypeInfo fileExcelTaskTypeInfo = null, ExcelMessageType messageType = ExcelMessageType.Info)
        {
            RowIndex = rowIndex.HasValue ? rowIndex.Value : 0;
            ColumnIndex = columnIndex.HasValue ? columnIndex.Value : 0;
            MessageType = messageType;
            Message = message;
            Detail = detail;
            this.FileExcelTaskTypeInfo = fileExcelTaskTypeInfo;
        }

        public int RowIndex { get; private set; }

        public int ColumnIndex { get; private set; }

        public string ColumnName
        {
            get
            {
                return SheetColumnNameUtil.ColumnIndexToColumnName(ColumnIndex);
            }
            set
            {
                ColumnIndex = SheetColumnNameUtil.ColumnNameToColumnIndex(value);
            }
        }
    }
}
