using System;

namespace MgSoft.Component
{
    public abstract class MgComponent : IMgComponent
    {
        public virtual void AfterBuilder(object lifetimeScope, object param = null)
        {
        }

        public virtual void BeforeBuilder(object lifetimeScope, object param = null)
        {
        }

        public abstract void Register(object builder);
    }
}
