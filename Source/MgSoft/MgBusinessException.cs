using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft
{
    public class MgBusinessException : Exception
    {
        public MgBusinessException()
        {
        }

        public MgBusinessException(string message) : base(message)
        {
        }

        public MgBusinessException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
