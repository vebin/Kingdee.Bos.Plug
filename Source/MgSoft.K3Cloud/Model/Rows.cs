using Kingdee.BOS.Core.CommonFilter.ConditionVariableAnalysis;
using Kingdee.BOS.Core.DependencyRules;
using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.Model
{
    public class Rows
    {
        public Biller Biller { get; }
        public Entity Entity { get; }

        public Rows(Biller biller,Entity entity)
        {
            this.Biller = biller;
            this.Entity = entity;
        }

        public int Count
        {
            get
            {
                return (this.Biller.Model.DataObject[Entity.Name] as DynamicObjectCollection).Count;
            }
        }

        public Row this[int rowIndex]
        {
            get
            {
                return new Row(this.Biller, this,rowIndex);
            }
        }

        public Cell this[int rowIndex,string name]
        {
            get
            {
                return this[rowIndex][name];
            }
        }
    }
}
