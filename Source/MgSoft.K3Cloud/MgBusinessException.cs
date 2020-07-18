using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud
{
    public class MgBusinessException:Exception
    {
        public MgBusinessException(string message) : base(message)
        {
        }
    }
}
