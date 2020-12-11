using Kingdee.BOS.Core.DynamicForm;
using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.Model.DynamicFormModel
{
    public class Cell : ValueObject, ICell
    {
        private readonly IModel Model;
        public string ColumnName { get; }
        public IRow Row { get; }

        public IDynamicFormModel DynamicFormModel => this.Model.ModelObject as IDynamicFormModel;

        public override object Value
        {
            get
            {
                var entityName = Row.Rows.Entity.Name;
                if (!DynamicFormModel.DataObject.DynamicObjectType.Properties.ContainsKey(entityName))
                {
                    throw new ArgumentException($"不存在单据体{Row.Rows.Entity.Name}");
                };
                var entity = DynamicFormModel.DataObject[entityName];

                var rows = (entity as DynamicObjectCollection);
                if (rows == null || rows.Count <= Row.RowIndex)
                {
                    throw new ArgumentException($"行下标越界{Row.RowIndex}");
                }

                var row = rows[Row.RowIndex];
                if (!row.DynamicObjectType.Properties.ContainsKey(ColumnName))
                {
                    throw new ArgumentException($"单据体{entityName}不存在列{ColumnName}");
                }

                return row[ColumnName];
            }
            set => DynamicFormModel.SetValue(ColumnName, value, Row.RowIndex);
        }

        public override string Number
        {
            get => ToDynamicObject()[FNumberKey].ToString();
            set => DynamicFormModel.SetItemValueByNumber(ColumnName, value, Row.RowIndex);
        }

        public override long Id
        {
            get => ToDynamicObject() == null ? 0 : (long)ToDynamicObject()[FIdKey];
            set => DynamicFormModel.SetItemValueByID(ColumnName, value, Row.RowIndex);
        }

        public Cell(IModel model, Row row, string columnName) : base(model)
        {
            Model = model;
            Row = row;
            ColumnName = columnName;

            var entityName = row.Rows.Entity.Name;
        }
    }
}
