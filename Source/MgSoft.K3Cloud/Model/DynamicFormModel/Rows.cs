using Kingdee.BOS.Core.CommonFilter.ConditionVariableAnalysis;
using Kingdee.BOS.Core.DependencyRules;
using Kingdee.BOS.Core.DynamicForm;
using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.Model.DynamicFormModel
{
    public class Rows : IRows
    {
        public IModel Model { get; }
        public IEntity Entity { get; }

        public IDynamicFormModel DynamicFormModel => Model.ModelObject as IDynamicFormModel;

        public Rows(IModel model, IEntity entity)
        {
            Model = model;
            Entity = entity;
        }

        public int Count
        {
            get
            {
                if(!DynamicFormModel.DataObject.DynamicObjectType.Properties.ContainsKey(Entity.Name))
                {
                    throw new ArgumentException($"不存在单据体{Entity.Name}");
                }
                var entity = DynamicFormModel.DataObject[Entity.Name];
                var rows = (entity as DynamicObjectCollection);
                if(rows==null)
                {
                    throw new ArgumentException($"名称为{Entity.Name}字段，不是单据体");
                }
                return rows.Count;
            }
        }

        public IRow this[int rowIndex]
        {
            get
            {
                return new Row(Model, this, rowIndex);
            }
        }

        public ICell this[int rowIndex, string name]
        {
            get
            {
                return this[rowIndex][name];
            }
        }
    }
}
