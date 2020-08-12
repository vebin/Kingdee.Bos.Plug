using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MgSoft.K3Cloud.Util
{
    public class PropertyMapNameAttribute : Attribute
    {

        public PropertyMapNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
