using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft
{
    public interface ILogger
    {
        ILog CreateLog();
    }
}
