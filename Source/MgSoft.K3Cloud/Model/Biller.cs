using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kingdee.BOS.Core.Bill.PlugIn;
using Kingdee.BOS.Core.DynamicForm.PlugIn.Args;
using Kingdee.BOS.Util;

namespace MgSoft.K3Cloud.Model
{
    public abstract class Biller : AbstractBillPlugIn
    {
        public Heads Heads;

        public Entities Entities;

        public Biller()
        {
            Heads = new Heads(this);
            Entities = new Entities(this);
        }
    }
}
