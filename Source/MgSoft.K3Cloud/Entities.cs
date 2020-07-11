using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud
{
    public class Entities
    {
        public Biller Biller { get; }

        public Entities(Biller biller)
        {
            this.Biller = biller;
        }

        public Entity this[string name]
        {
            get
            {
                return new Entity(Biller, this,name);
            }
        }
    }
}
