namespace MgSoft.Component
{
    public interface IMgComponent
    {
        void BeforeBuilder(object lifetimeScope, object param = null);
        void Register(object builder);
        void AfterBuilder(object lifetimeScope, object param = null);
    }
}