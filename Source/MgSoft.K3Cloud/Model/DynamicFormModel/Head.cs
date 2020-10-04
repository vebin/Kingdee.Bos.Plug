using Kingdee.BOS.Core.DynamicForm;
using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.Model.DynamicFormModel
{
    public class Head : ValueObject, IHead
    {
        public IHeads Heads { get; }

        public string HeadName { get; }

        public IDynamicFormModel DynamicFormModel { get; private set; }

        public override object Value
        {
            get => DynamicFormModel.DataObject[HeadName];
            set => DynamicFormModel.SetValue(HeadName, value);
        }

        public override string Number
        {
            get => ToDynamicObject()[FNumberKey].ToString();
            set => DynamicFormModel.SetItemValueByNumber(HeadName, value, 0);
        }

        public override long Id
        {
            get => (long)ToDynamicObject()[FIdKey];
            set => DynamicFormModel.SetItemValueByID(HeadName, value, 0);
        }

        public Head(IModel model, IHeads heads, string name) : base(model)
        {
            Heads = heads;
            HeadName = name;
            DynamicFormModel = this.Model.ModelObject as IDynamicFormModel;
        }
    }
}
