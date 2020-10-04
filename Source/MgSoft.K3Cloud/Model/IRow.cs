namespace MgSoft.K3Cloud.Model
{
    public interface IRow
    {
        ICell this[string name] { get; }

        IModel Model { get; }
        int RowIndex { get; }
        IRows Rows { get; }
    }
}