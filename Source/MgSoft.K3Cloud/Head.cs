using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud
{
    public class Head
    {
        private readonly Biller biller;

        public Head(Biller biller)
        {
            this.biller = biller;
        }

        public HeadObject this[string name]
        {
            get
            {
                return new HeadObject(biller, this, name);
            }
        }
    }
}
