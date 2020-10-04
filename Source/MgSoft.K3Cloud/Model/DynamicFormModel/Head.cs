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

        public DynamicObject DynamicObject => DynamicFormModel.DataObject as DynamicObject;

        public IDynamicFormModel DynamicFormModel => this.Model.ModelObject as IDynamicFormModel;

        public override object Value
        {
            get
            {   
                if(!DynamicFormModel.DataObject.DynamicObjectType.Properties.ContainsKey(HeadName))
                {
                    throw new ArgumentException($"不存在单据头{HeadName}");
                }
                return DynamicFormModel.DataObject[HeadName];
            }
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
        }
    }
}
