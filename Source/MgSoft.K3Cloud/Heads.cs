using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud
{
    public class Heads
    {
        private readonly Biller biller;

        public Heads(Biller biller)
        {
            this.biller = biller;
        }

        public Head this[string name]
        {
            get
            {
                return new Head(biller, this, name);
            }
        }
    }
}
