using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi
{
    public class ApiException : Exception
    {
        public ApiException(string message) : base(message)
        {
        }
    }
}
