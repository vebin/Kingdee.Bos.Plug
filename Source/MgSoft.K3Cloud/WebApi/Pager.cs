using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.WebApi
{
    public class Pager
    {
        public int PageIndex { get; set; } = 0;

        public int RowCount { get; set; } = 100;
    }
}
