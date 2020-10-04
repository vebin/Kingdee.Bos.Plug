using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.Model.DynamicFormModel
{
    public class Entity : IEntity
    {
        public IModel ModelOjbect { get; }
        public IEntities Entities { get; }
        public string Name { get; }

        public Entity(IModel model, IEntities entities, string Name)
        {
            ModelOjbect = model;
            Entities = entities;
            this.Name = Name;
        }

        public IRows Rows
        {
            get
            {
                return new Rows(ModelOjbect, this);
            }
        }
    }
}
