using Kingdee.BOS.Orm.DataEntity;

namespace MgSoft.K3Cloud.Model
{
    public interface IHeads
    {
        DynamicObject DynamicObject { get;}

        IHead this[string name] { get; }
    }
}