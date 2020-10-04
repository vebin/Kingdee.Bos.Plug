namespace MgSoft.K3Cloud.Model
{
    public interface IRows
    {
        IRow this[int rowIndex] { get; }
        ICell this[int rowIndex, string name] { get; }

        IModel Model { get; }
        int Count { get; }
        IEntity Entity { get; }
    }
}