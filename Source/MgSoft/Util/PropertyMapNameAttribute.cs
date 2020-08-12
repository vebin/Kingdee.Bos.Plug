using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MgSoft.Util
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
