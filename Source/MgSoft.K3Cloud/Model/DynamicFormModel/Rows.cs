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

        public IDynamicFormModel DynamicFormModel { get; private set; }

        public Rows(IModel model, IEntity entity)
        {
            Model = model;
            Entity = entity;
        }

        public int Count
        {
            get
            {
                return (DynamicFormModel.DataObject[Entity.Name] as DynamicObjectCollection).Count;
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
