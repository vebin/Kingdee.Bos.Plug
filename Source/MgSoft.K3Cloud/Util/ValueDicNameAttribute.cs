using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MgSoft.K3Cloud.WebApi
{
    public class ValueDicNameAttribute : Attribute
    {
        
        public ValueDicNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
