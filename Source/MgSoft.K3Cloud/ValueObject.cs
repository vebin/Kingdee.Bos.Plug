using Kingdee.BOS.Core.Bill.PlugIn;
using Kingdee.BOS.Core.Metadata;
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
        private const string FIdKey = "FId";
        private const string FNumberKey = "FNumber";
        private const string FNameKey = "FName";

        public Biller Biller { get; }

        public abstract object Value { get; }


        protected ValueObject(Biller biller)
        {
            Biller = biller;
        }
        private bool IsHead()
        {
            return this is Head;
        }

        private bool IsCell()
        {
            return this is Cell;
        }

        private Cell ToCellObject()
        {
            return this as Cell;
        }

        private Head ToHeadObject()
        {
            return this as Head;
        }

        #region 基础资料
        public int Id 
        {
            get
            {
                return (int)this.ToDynamicObject()[FIdKey];
            }
            set
            {
                if (this.IsHead())
                {
                    //给单据头赋值
                    this.Biller.Model.SetItemValueByID(this.ToHeadObject().HeadName, value, 0);
                }
                else if (this.IsCell())
                {
                    //给单据体赋值
                    this.Biller.Model.SetItemValueByID(this.ToCellObject().ColumnName, value, this.ToCellObject().Row.RowIndex);
                }
                else
                {
                    throw new Exception("框架异常，没有初始化对像为单据头或单据体");
                }
            }
        }

        public string Number
        {
            get
            {
                return this.ToDynamicObject()[FNumberKey].ToString();
            }
            set
            {
                if (this.IsHead())
                {
                    //给单据头赋值
                    this.Biller.Model.SetItemValueByNumber(this.ToHeadObject().HeadName, value, 0);
                }
                else if(this.IsCell())
                {
                    //给单据体赋值
                    this.Biller.Model.SetItemValueByNumber(this.ToCellObject().ColumnName, value, this.ToCellObject().Row.RowIndex);
                }
                else
                {
                    throw new Exception("框架异常，没有初始化对像为单据头或单据体");
                }
            }
        }

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
            if(this.IsNull())
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
            return this.ToDateTime() ;
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
    }
}
