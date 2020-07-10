using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud
{
    public class Body
    {
        private readonly Biller biller;
        private readonly DynamicObject dataObject;

        public Body(Biller biller)
        {
            this.biller = biller;
            this.dataObject = this.biller.Model.DataObject;
        }

        public BodyObject this[string name]
        {
            get
            {
                return new BodyObject(biller, name);
            }
        }
    }
}
