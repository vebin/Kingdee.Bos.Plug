using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud
{
    public class HeadObject : ValueObject
    {
        public Head Head { get; }

        public string HeadName { get; }

        protected override DynamicObject DataObject { get; }

        public HeadObject(Biller biller,Head head, string name) : base(biller)
        {
            Head = head;
            this.HeadName = name;

            this.DataObject = (DynamicObject)this.Biller.Model.DataObject[name];
        }
    }
}
