using MgSoft.Excel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MgSoft.Import.Excel.Model
{
    public class AggregateExcelMessage
    {
        public List<ExcelMessage> ExcelMessages { get; set; }

        private object lockObject = new object();

        public AggregateExcelMessage()
        {
            ExcelMessages = new List<ExcelMessage>();
        }

        public void Add(AggregateExcelMessage aggregateExcelMessage)
        {
            ExcelMessages.AddRange(aggregateExcelMessage.ExcelMessages);
        }

        public bool HasMessage()
        {
            return ExcelMessages.Any();
        }

        public bool HasError()
        {
            return ExcelMessages.Any(p => p.MessageType == ExcelMessageType.Error);
        }

        public bool HasWaing()
        {
            return ExcelMessages.Any(p => p.MessageType == ExcelMessageType.Waring);
        }

        public bool HasInfo()
        {
            return ExcelMessages.Any(p => p.MessageType == ExcelMessageType.Info);
        }

        public void Add(ExcelMessage excelMessage)
        {
            lock (lockObject)
            {
                ExcelMessages.Add(excelMessage);
            }
        }
        public void Add(string message, string detail, ExcelMessageType excelMessageType, FileExcelTaskTypeInfo fileExcelTaskTypeInfo)
        {
            lock (lockObject)
            {
                this.Add(new ExcelMessage(message: message, detail: detail, excelMessageType: excelMessageType, fileExcelTaskTypeInfo: fileExcelTaskTypeInfo));
            }
        }

        //public void Add(int rowIndex, int columnIndex, string message, string detail, ExcelMessageType excelMessageType, FileExcelTaskTypeInfo fileExcelTaskTypeInfo)
        //{
        //    lock (lockObject)
        //    {
        //        this.Add(new ExcelMessage(rowIndex, columnIndex, message:message, detail, excelMessageType: excelMessageType, fileExcelTaskTypeInfo: fileExcelTaskTypeInfo));
        //    }
        //}
        public void Add(int? rowIndex, int? columnIndex, string message, string detail, ExcelMessageType excelMessageType, FileExcelTaskTypeInfo fileExcelTaskTypeInfo)
        {
            lock (lockObject)
            {
                this.Add(new ExcelMessage(rowIndex, columnIndex, message: message, detail, excelMessageType: excelMessageType, fileExcelTaskTypeInfo: fileExcelTaskTypeInfo));
            }
        }

        public void Add(ExcelErrorMessage excelErrorMessage, ExcelMessageType excelMessageType, FileExcelTaskTypeInfo fileExcelTaskTypeInfo)
        {
            lock (lockObject)
            {
                this.Add(new ExcelMessage(rowIndex: excelErrorMessage.RowIndex, columnIndex: excelErrorMessage.ColumnIndex, message: excelErrorMessage.Message, detail: excelErrorMessage.Detailed, excelMessageType: excelMessageType, fileExcelTaskTypeInfo: fileExcelTaskTypeInfo));
            }
        }

        public void Clear()
        {
            lock (lockObject)
            {
                ExcelMessages.Clear();
            }
        }

        public void AddRange(List<ExcelErrorMessage> errorMessages, ExcelMessageType excelMessageType, FileExcelTaskTypeInfo fileExcelTaskTypeInfo)
        {
            lock (lockObject)
            {
                foreach (ExcelErrorMessage errorMessage in errorMessages)
                {
                    this.Add(errorMessage, excelMessageType, fileExcelTaskTypeInfo);
                }
            }
        }
    }
}
