using Kingdee.BOS.KDHttpUtility;
using Kingdee.BOS.Orm.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud
{
    public abstract class ValueObject
    {
        public Biller Biller { get; }

        protected abstract DynamicObject DataObject { get; }

        protected ValueObject(Biller biller)
        {
            Biller = biller;
        }

        public DynamicObject Value
        {
            get
            {
                return DataObject;
            }
        }

        #region 基础资料
        public object Id 
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public object Number
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        public bool IsNull()
        {
            return this.Value == null;
        }

        #region toString
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
            var dataObject = this.Value;

            if (dataObject == null)
            {
                return defalutValue;
            }
            return dataObject.ToString();
        }
        #endregion

        #region toInt
        public int ToInt()
        {
            return Convert.ToInt32(this.ToString());
        }

        public int ToIntOrDefault(int defaultValue)
        {
            var value = this.ToStringOrNull();
            if(value==null)
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
            var value = this.ToStringOrNull();
            if (value == null)
            {
                return defaultValue;
            }
            return Convert.ToInt32(value);
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

        #region toDataTime        
        public DateTime ToDataTime()
        {
            return Convert.ToDateTime(this.ToString());
        }

        public DateTime TryToDateTimeOrDefault(DateTime defaultValue)
        {
            try
            {
                return this.ToDataTime();
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
                return this.ToDataTime();
            }
            catch
            {
                return defaultValue;
            }
        }
        #endregion
    }
}
