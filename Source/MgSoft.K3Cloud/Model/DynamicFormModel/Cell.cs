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

        public IDynamicFormModel DynamicFormModel { get; private set; }

        public override object Value
        {
            get => (DynamicFormModel.DataObject[Row.Rows.Entity.Name] as DynamicObjectCollection)[Row.RowIndex][ColumnName];
            set => DynamicFormModel.SetValue(ColumnName, value, Row.RowIndex);
        }

        public override string Number
        {
            get => ToDynamicObject()[FNumberKey].ToString();
            set => DynamicFormModel.SetItemValueByNumber(ColumnName, value, Row.RowIndex);
        }

        public override long Id
        {
            get => (long)ToDynamicObject()[FIdKey];
            set => DynamicFormModel.SetItemValueByID(ColumnName, value, Row.RowIndex);
        }

        public Cell(IModel model, Row row, string columnName) : base(model)
        {
            Model = model;
            Row = row;
            ColumnName = columnName;

            var entityName = row.Rows.Entity.Name;
            DynamicFormModel = model.ModelObject as IDynamicFormModel;
        }
    }
}
