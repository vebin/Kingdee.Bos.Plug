using System;

namespace MgSoft.Component
{
    public abstract class MgComponent : IMgComponent
    {
        public abstract void Register(object builder);
    }
}
