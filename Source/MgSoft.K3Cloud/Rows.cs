using Kingdee.BOS.Core.CommonFilter.ConditionVariableAnalysis;
using Kingdee.BOS.Core.DependencyRules;
using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud
{
    public class Rows
    {
        private readonly Biller biller;
        private readonly DynamicObject dataObject;
        private string bodyName;
        public Rows(Biller biller)
        {
            this.biller = biller;
            this.dataObject = this.biller.Model.DataObject;
        }

        public int Count
        {
            get
            {
                return (dataObject[bodyName] as DynamicObjectCollection).Count;
            }
        }


        public Rows(Biller biller, string bodyName) : this(biller)
        {
            this.bodyName = bodyName;
        }

        public Row this[int rowIndex]
        {
            get
            {
                return new Row(this.biller, this.bodyName, rowIndex);
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
