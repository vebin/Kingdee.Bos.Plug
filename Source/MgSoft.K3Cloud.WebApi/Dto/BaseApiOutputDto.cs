using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi
{
    public class BaseApiOutputDto
    {
        public virtual long Id { get; set; }
        public virtual string Number { get; set; }
        public virtual long DIndex { get; set; }
    }
}
