using MgSoft.K3Cloud.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MgSoft.K3Cloud.Model
{
    public interface IModel
    {
        IHeads Heads { get; }

        IEntities Entities { get; }

        Object ModelObject { get; }
    }
}
