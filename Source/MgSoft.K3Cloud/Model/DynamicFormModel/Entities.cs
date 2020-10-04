using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.Model.DynamicFormModel
{
    public class Entities : IEntities
    {
        public IModel Model { get; }

        public Entities(IModel model)
        {
            Model = model;
        }

        public IEntity this[string name]
        {
            get
            {
                return new Entity(Model, this, name);
            }
        }
    }
}
