using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MgSoft.K3Cloud.Model.DynamicObjectModel
{
    public class Heads : IHeads
    {
        public DynamicObject DynamicObject { get; private set; }

        public Heads()
        {
        }
        
        public Heads(DynamicObject dynamicObject)
        {
            DynamicObject = dynamicObject;
        }

        public IHead this[string name]
        {
            get
            {
                if(!DynamicObject.DynamicObjectType.Properties.ContainsKey(name))
                {
                    throw new ArgumentException($"不存在单据头字段{name}");
                }
                return new Head(DynamicObject[name] as DynamicObject,this, name);
            }
        }
    }
}
