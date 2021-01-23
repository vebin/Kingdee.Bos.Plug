using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel.Model
{
    public class ExcelMessage
    {
        public ExcelMessage(string message , ExcelMessageType messageType = ExcelMessageType.Info, string detail = "")
            :this(0,0,message,messageType,detail)
        {
        }

        public ExcelMessage(int rowIndex, int columnIndex, string message = "", ExcelMessageType messageType = ExcelMessageType.Info, string detail = "")
        {
            RowIndex = rowIndex;
            ColumnIndex = columnIndex;
            MessageType = messageType;
            Message = message;
            Detail = detail;
        }
        public ExcelMessage(int? rowIndex, int? columnIndex, string message = "", ExcelMessageType messageType = ExcelMessageType.Info, string detail = "")
        {
            RowIndex = rowIndex.HasValue? rowIndex.Value:0;
            ColumnIndex = columnIndex.HasValue?columnIndex.Value:0;
            MessageType = messageType;
            Message = message;
            Detail = detail;
        }

        public int RowIndex { get; }

        public int ColumnIndex { get; }

        public ExcelMessageType MessageType { get; }

        public string Message { get; }

        public string Detail { get; }
    }
}
