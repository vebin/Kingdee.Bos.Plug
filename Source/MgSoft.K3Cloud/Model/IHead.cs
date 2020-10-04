using Kingdee.BOS.Orm.DataEntity;
using MgSoft.K3Cloud.Model.DynamicFormModel;

namespace MgSoft.K3Cloud.Model
{
    public interface IHead: IValueObject
    {
        DynamicObject DynamicObject { get; }

        string HeadName { get; }
        IHeads Heads { get; }
        long Id { get; set; }
        string Number { get; set; }
        object Value { get; set; }
    }
}