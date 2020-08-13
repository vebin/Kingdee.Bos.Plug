using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Dto
{
    public class Result
    {
        public ResponseStatus ResponseStatus { get; set; }
    }

    public class ResponseStatus
    {
        public int ErrorCode { get; set; }
        public bool IsSuccess { get; set; }

        public Errors[] Errors { get; set; }

        public string[] SuccessEntitys { get; set; }

        public string[] SuccessMessages { get; set; }
        public int MsgCode { get; set; }
    }

    public class Errors
    {
        public string FieldName { get; set; }
        public string Message { get; set; }
        public int DIndex { get; set; }

    }
}