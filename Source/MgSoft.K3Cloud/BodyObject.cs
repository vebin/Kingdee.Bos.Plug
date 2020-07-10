using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud
{
    public class BodyObject
    {
        private readonly Biller biller;
        private readonly string bodyName;
        private readonly DynamicObject dataObject;

        public BodyObject(Biller biller,string bodyName)
        {
            this.biller = biller;
            this.bodyName = bodyName;
            this.dataObject = this.biller.Model.DataObject;
        }

        public Rows Rows
        {
            get
            {
                return new Rows(biller,bodyName);
            }
        }
    }
}
