namespace MgSoft.K3Cloud.Model
{
    public interface IEntity
    {
        IModel ModelOjbect { get; }
        IEntities Entities { get; }
        string Name { get; }
        IRows Rows { get; }
    }
}