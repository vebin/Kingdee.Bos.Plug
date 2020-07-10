using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud
{
    public class Cell: ValueObject
    {
        private readonly Biller biller;
        public string ColumnName { get; }
        public Row Row { get; }

        protected override DynamicObject DataObject { get; }

        public Cell(Biller biller,Row row, string columnName) :base(biller)
        {
            this.biller = biller;
            this.Row = row;
            this.ColumnName = columnName;

            this.DataObject = (DynamicObject)(biller.Model.DataObject[row.BodyName] as DynamicObjectCollection)[row.RowIndex][ColumnName];
        }
    }
}
