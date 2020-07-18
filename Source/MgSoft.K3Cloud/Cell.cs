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

        public override object Value 
        {
            get =>(biller.Model.DataObject[this.Row.Rows.Entity.Name] as DynamicObjectCollection)[this.Row.RowIndex][ColumnName];
            set => this.biller.Model.SetValue(ColumnName, value, this.Row.RowIndex);
        }

        public override string Number 
        {
            get => this.ToDynamicObject()[FNumberKey].ToString();
            set => this.Biller.Model.SetItemValueByNumber(this.ColumnName, value, this.Row.RowIndex);
        }

        public override long Id
        {
            get => (long)this.ToDynamicObject()[FIdKey];
            set => this.Biller.Model.SetItemValueByID(this.ColumnName, value, this.Row.RowIndex);
        }

        public Cell(Biller biller,Row row, string columnName) :base(biller)
        {
            this.biller = biller;
            this.Row = row;
            this.ColumnName = columnName;

            var entityName = row.Rows.Entity.Name;
        }
    }
}
