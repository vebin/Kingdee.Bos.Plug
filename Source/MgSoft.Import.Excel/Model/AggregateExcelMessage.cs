﻿using MgSoft.Excel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel.Model
{
    public class AggregateExcelMessage
    {
        public List<ExcelMessage> CheckMessages { get; set; }

        private object lockObject = new object();

        public AggregateExcelMessage()
        {
            CheckMessages = new List<ExcelMessage>();
        }

        public void Add(ExcelMessage checkMessage)
        {
            lock (lockObject)
            {
                CheckMessages.Add(checkMessage);
            }
        }
        public void Add(string message, ExcelMessageType messageType = ExcelMessageType.Info, string detail = "")
        {
            lock (lockObject)
            {
                CheckMessages.Add(new ExcelMessage(message, messageType, detail));
            }
        }

        public void Add(int rowIndex, int columnIndex, string message = "", ExcelMessageType messageType = ExcelMessageType.Info, string detail = "")
        {
            lock (lockObject)
            {
                CheckMessages.Add(new ExcelMessage(rowIndex, columnIndex, message, messageType, detail));
            }
        }

        public void Add(ExcelErrorMessage excelErrorMessage, ExcelMessageType messageType = ExcelMessageType.Error)
        {
            lock (lockObject)
            {
                CheckMessages.Add(new ExcelMessage(excelErrorMessage.RowIndex, excelErrorMessage.ColumnIndex, excelErrorMessage.Message, messageType, excelErrorMessage.Detailed));
            }
        }

        public void Clear()
        {
            lock (lockObject)
            {
                CheckMessages.Clear();
            }
        }

        public void AddRange(List<ExcelErrorMessage> errorMessages,ExcelMessageType messageType=ExcelMessageType.Error)
        {
            lock (lockObject)
            {
                foreach (ExcelErrorMessage errorMessage in errorMessages)
                {
                    this.Add(errorMessage);
                }
            }
        }
    }
}
