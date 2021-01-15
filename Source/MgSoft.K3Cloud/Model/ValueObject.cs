using Kingdee.BOS.Core.Bill.PlugIn;
using Kingdee.BOS.Core.Metadata;
using Kingdee.BOS.KDHttpUtility;
using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.Model
{
    public abstract class ValueObject : IValueObject
    {
        protected const string FIdKey = "Id";
        protected const string FNumberKey = "Number";
        protected const string FNameKey = "Name";

        public IModel Model { get; }

        public abstract object Value { get; set; }


        protected ValueObject(IModel model)
        {
            Model = model;
        }

        #region 基础资料
        public abstract long Id { get; set; }

        public abstract string Number { get; set; }

        public string Name
        {
            get
            {
                return this.ToDynamicObject()[FNameKey].ToString();
            }
        }
        #endregion

        public bool IsNull()
        {
            return this.Value == null;
        }

        public DynamicObject ToDynamicObject()
        {
            return (DynamicObject)this.Value;
        }

        #region toString
        public override string ToString()
        {
            return Value.ToString();
        }

        public string ToStringOrNull()
        {
            return this.ToStringOrDefault(null);
        }

        public string ToStringOrEmpty()
        {
            return this.ToStringOrDefault(string.Empty);
        }

        public string ToStringOrDefault(string defalutValue)
        {
            if (this.IsNull())
            {
                return defalutValue;
            }
            return Value.ToString();
        }
        #endregion

        #region toInt
        public int ToInt()
        {
            return (int)this.Value;
        }

        public int ToIntOrDefault(int defaultValue)
        {
            var value = this.ToStringOrNull();
            if (this.IsNull())
            {
                return defaultValue;
            }
            return Convert.ToInt32(value);
        }

        public int TryToIntOrDefault(int defaultValue)
        {
            try
            {
                return this.ToIntOrDefault(defaultValue);
            }
            catch
            {
                return defaultValue;
            }
        }
        #endregion

        #region toDouble
        public double ToDouble()
        {
            return Convert.ToDouble(this.ToString());
        }

        public double ToDoubleOrDefault(double defaultValue)
        {
            if (this.IsNull())
            {
                return defaultValue;
            }
            return (double)this.Value;
        }

        public double TryToDoubleOrDefault(double defaultValue)
        {
            try
            {
                return this.ToDoubleOrDefault(defaultValue);
            }
            catch
            {
                return defaultValue;
            }
        }
        #endregion

        #region toDateTime        
        public DateTime ToDateTime()
        {
            return (DateTime)this.Value;
        }
        public DateTime? ToDateTimeOrNull()
        {
            if (this.IsNull()) return null;
            return this.ToDateTime();
        }


        public DateTime TryToDateTimeOrDefault(DateTime defaultValue)
        {
            try
            {
                return this.ToDateTime();
            }
            catch
            {
                return defaultValue;
            }
        }

        public DateTime? TryToDateTimeOrNull(DateTime? defaultValue)
        {
            try
            {
                return this.ToDateTime();
            }
            catch
            {
                return defaultValue;
            }
        }
        #endregion

        #region toLong
        public long ToLong()
        {
            return (long)this.Value;
        }

        public long? ToLongOrNull()
        {
            if (this.IsNull()) return null;
            return this.ToLong();
        }

        public long TryToLongOrDefault(long defaultValue)
        {
            try
            {
                return this.ToLong();
            }
            catch
            {
                return defaultValue;
            }
        }

        public long? TryToLongOrNull(long? defaultValue)
        {
            try
            {
                return this.ToLong();
            }
            catch
            {
                return defaultValue;
            }
        }
        #endregion

        #region toDec
        public decimal ToDecimal()
        {
            return (decimal)this.Value;
        }

        public decimal? ToDecimalOrNull()
        {
            if (this.IsNull()) return null;
            return this.ToLong();
        }

        public decimal TryToDecimalOrDefault(decimal defaultValue)
        {
            try
            {
                return this.ToDecimal();
            }
            catch
            {
                return defaultValue;
            }
        }

        public decimal? TryToDecimalOrNull(decimal? defaultValue)
        {
            try
            {
                return this.ToDecimal();
            }
            catch
            {
                return defaultValue;
            }
        }

        public bool TryToBooleanOrDefault(bool defaultValue)
        {
            try
            {
                return this.ToBoolean();
            }
            catch
            {
                return defaultValue;
            }
        }

        public bool? TryToBooleanOrDefault(bool? defaultValue)
        {
            try
            {
                return this.ToBoolean();
            }
            catch
            {
                return defaultValue;
            }
        }

        public bool ToBoolean()
        {
            return (bool)this.Value;
        }
        #endregion
    }
}
