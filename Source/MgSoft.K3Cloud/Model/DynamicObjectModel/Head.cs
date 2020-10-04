using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MgSoft.K3Cloud.Model.DynamicObjectModel
{
    public class Head : IHead
    {
        public DynamicObject DynamicObject { get; private set; }


        public Head(DynamicObject dynamicObject,Heads heads,string headName)
        {
            DynamicObject = dynamicObject;
            Heads = heads;
            HeadName = headName;
        }

        public string HeadName { get; private set; }

        public IHeads Heads { get; private set; }

        public long Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Number { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IModel Model => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public bool IsNull()
        {
            throw new NotImplementedException();
        }

        public DateTime ToDateTime()
        {
            throw new NotImplementedException();
        }

        public DateTime? ToDateTimeOrNull()
        {
            throw new NotImplementedException();
        }

        public decimal ToDecimal()
        {
            throw new NotImplementedException();
        }

        public decimal? ToDecimalOrNull()
        {
            throw new NotImplementedException();
        }

        public double ToDouble()
        {
            throw new NotImplementedException();
        }

        public double ToDoubleOrDefault(double defaultValue)
        {
            throw new NotImplementedException();
        }

        public DynamicObject ToDynamicObject()
        {
            throw new NotImplementedException();
        }

        public int ToInt()
        {
            throw new NotImplementedException();
        }

        public int ToIntOrDefault(int defaultValue)
        {
            throw new NotImplementedException();
        }

        public long ToLong()
        {
            throw new NotImplementedException();
        }

        public long? ToLongOrNull()
        {
            throw new NotImplementedException();
        }

        public string ToStringOrDefault(string defalutValue)
        {
            throw new NotImplementedException();
        }

        public string ToStringOrEmpty()
        {
            throw new NotImplementedException();
        }

        public string ToStringOrNull()
        {
            throw new NotImplementedException();
        }

        public DateTime TryToDateTimeOrDefault(DateTime defaultValue)
        {
            throw new NotImplementedException();
        }

        public DateTime? TryToDateTimeOrNull(DateTime? defaultValue)
        {
            throw new NotImplementedException();
        }

        public decimal TryToDecimalOrDefault(decimal defaultValue)
        {
            throw new NotImplementedException();
        }

        public decimal? TryToDecimalOrNull(decimal? defaultValue)
        {
            throw new NotImplementedException();
        }

        public double TryToDoubleOrDefault(double defaultValue)
        {
            throw new NotImplementedException();
        }

        public int TryToIntOrDefault(int defaultValue)
        {
            throw new NotImplementedException();
        }

        public long TryToLongOrDefault(long defaultValue)
        {
            throw new NotImplementedException();
        }

        public long? TryToLongOrNull(long? defaultValue)
        {
            throw new NotImplementedException();
        }
    }
}
