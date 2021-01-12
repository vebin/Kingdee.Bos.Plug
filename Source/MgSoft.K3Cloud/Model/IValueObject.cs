using Kingdee.BOS.Orm.DataEntity;
using System;

namespace MgSoft.K3Cloud.Model
{
    public interface IValueObject
    {
        long Id { get; set; }
        IModel Model { get; }
        string Name { get; }
        string Number { get; set; }
        object Value { get; set; }

        bool IsNull();
        DateTime ToDateTime();
        DateTime? ToDateTimeOrNull();
        decimal ToDecimal();
        decimal? ToDecimalOrNull();
        double ToDouble();
        double ToDoubleOrDefault(double defaultValue);
        DynamicObject ToDynamicObject();
        int ToInt();
        int ToIntOrDefault(int defaultValue);
        long ToLong();
        long? ToLongOrNull();
        string ToString();
        string ToStringOrDefault(string defalutValue);
        string ToStringOrEmpty();
        string ToStringOrNull();
        DateTime TryToDateTimeOrDefault(DateTime defaultValue);
        DateTime? TryToDateTimeOrNull(DateTime? defaultValue);
        decimal TryToDecimalOrDefault(decimal defaultValue);
        decimal? TryToDecimalOrNull(decimal? defaultValue);
        double TryToDoubleOrDefault(double defaultValue);
        int TryToIntOrDefault(int defaultValue);
        long TryToLongOrDefault(long defaultValue);
        long? TryToLongOrNull(long? defaultValue);

        bool ToBoolean();

        bool TryToBooleanOrDefault(bool defaultValue);

        bool? TryToBooleanOrDefault(bool? defaultValue);
    }
}