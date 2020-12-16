using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft
{
    public class MgException : Exception
    {
        public MgException()
        {
        }

        public MgException(string message) : base(message)
        {
        }

        public MgException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
