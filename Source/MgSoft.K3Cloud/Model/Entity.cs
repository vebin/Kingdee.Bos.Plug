using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.Model
{
    public class Entity
    {
        public Biller Biller { get; }
        public Entities Entities { get; }
        public string Name { get; }

        public Entity(Biller biller,Entities entities, string Name)
        {
            this.Biller = biller;
            this.Entities = entities;
            this.Name = Name;
        }

        public Rows Rows
        {
            get
            {
                return new Rows(Biller, this);
            }
        }
    }
}
