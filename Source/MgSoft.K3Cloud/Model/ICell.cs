namespace MgSoft.K3Cloud.Model
{
    public interface ICell:IValueObject
    {
        string ColumnName { get; }
        long Id { get; set; }
        string Number { get; set; }
        IRow Row { get; }
        object Value { get; set; }
    }
}