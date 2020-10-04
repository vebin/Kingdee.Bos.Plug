namespace MgSoft.K3Cloud.Model
{
    public interface IEntities
    {
        IEntity this[string name] { get; }

        IModel Model { get; }
    }
}