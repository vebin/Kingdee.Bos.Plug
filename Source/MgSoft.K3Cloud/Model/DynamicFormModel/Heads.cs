using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.Model.DynamicFormModel
{
    public class Heads : IHeads
    {
        private readonly IModel model;

        public Heads(IModel model)
        {
            this.model = model;
        }

        public IHead this[string name]
        {
            get
            {
                return new Head(model, this, name);
            }
        }
    }
}
