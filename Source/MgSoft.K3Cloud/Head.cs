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

        public override Object Value 
        {
            get=> this.Biller.Model.DataObject[this.HeadName];
            set => this.Biller.Model.SetValue(this.HeadName, value);
        }

        public override string Number
        {
            get => this.ToDynamicObject()[FNumberKey].ToString();
            set => this.Biller.Model.SetItemValueByNumber(this.HeadName, value,0);
        }

        public override long Id
        {
            get => (long)this.ToDynamicObject()[FIdKey];
            set => this.Biller.Model.SetItemValueByID(this.HeadName, value, 0);
        }

        public Head(Biller biller, Heads heads, string name) : base(biller)
        {
            this.Heads = heads;
            this.HeadName = name;
        }
    }
}
