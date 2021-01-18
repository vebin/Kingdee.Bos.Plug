using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Log.MgSerilog
{
    public class MgSerilogger : IMgSerilogger
    {
        protected IMgSerilog log;
        public MgSerilogger(IMgSerilog mgSerilog)
        {
            this.log = mgSerilog;
        }

        ILog ILogger.CreateLog()
        {
            return log;
        }
    }
}
