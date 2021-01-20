using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft
{
    public interface IMgLogger
    {
        IMgLog CreateLog();
    }
}
