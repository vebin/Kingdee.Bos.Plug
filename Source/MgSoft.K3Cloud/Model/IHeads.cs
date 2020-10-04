namespace MgSoft.K3Cloud.Model
{
    public interface IHeads
    {
        IHead this[string name] { get; }
    }
}