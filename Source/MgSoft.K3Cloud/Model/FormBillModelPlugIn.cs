using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kingdee.BOS.Core.Bill.PlugIn;
using Kingdee.BOS.Core.DynamicForm.PlugIn.Args;
using Kingdee.BOS.Util;
using MgSoft.K3Cloud.Model.DynamicFormModel;

namespace MgSoft.K3Cloud.Model
{
    public abstract class FormBillModelPlugIn : AbstractBillPlugIn,IModel
    {
        public IHeads Heads { get; private set; }

        public IEntities Entities { get; private set; }

        /// <summary>
        /// 模型对像
        /// </summary>
        public object ModelObject => this.Model; 

        public FormBillModelPlugIn()
        {
            Heads = new Heads(this);
            Entities = new Entities(this);
        }
    }
}
