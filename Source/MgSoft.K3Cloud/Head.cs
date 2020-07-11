using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud
{
    public class Head : ValueObject
    {
        public Heads Heads { get; }

        public string HeadName { get; }

        public override Object Value { get; }

        public Head(Biller biller,Heads heads, string name) : base(biller)
        {
            this.Heads = heads;
            this.HeadName = name;
            this.Value = this.Biller.Model.DataObject[name];
        }
    }
}
