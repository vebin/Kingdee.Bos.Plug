using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kingdee.BOS.Core.Bill.PlugIn;
using Kingdee.BOS.Core.DynamicForm.PlugIn.Args;
using Kingdee.BOS.Util;

namespace MgSoft.K3Cloud
{
    public abstract class Biller : AbstractBillPlugIn
    {
        public Head Head;

        public Body Body;

        public Biller()
        {
            Head = new Head(this);
            Body = new Body(this);
        }

        public override void OnAfterPrint(AfterPrintEventArgs e)
        {
            var headName = "";
            var bodyName = "";
            var cellName = "";
            var cellItemName = "";

            //单据头操作
            var id = this.Head[headName].Id;//基础资料，返回Id
            var number = this.Head[headName].Number;//基础资料，返回代码
            var name = this.Head[headName].Name;//基础资料，返回名称

            var value = this.Head[""].Value;//返回DynamicObject对像
            var toStringOrEmpty = this.Head[""].ToStringOrEmpty();//转字符串或返回空串
            var toDouble = this.Head[""].ToDouble();//转为浮点数
            var toInt = this.Head[""].ToInt();//转为整数
            var toIntOrDefault = this.Head[""].ToIntOrDefault(0);//转为整数，如果为null则返回默认值
            var tryToIntOrDefault = this.Head[""].TryToIntOrDefault(0);//转为整数，如果异常则返回默认值
            var toDataTime = this.Head[""].ToDataTime();//转换为DateTime
            var tryToDateTimeOrDefault = this.Head[""].TryToDateTimeOrDefault(DateTime.Now);//转换为DateTime，如果出现异常则返回当前时间
            var isNull = this.Head[""].IsNull();

            //单据头赋值
            this.Head[headName].Number = "01.01";//使用代码给基础资料赋值

            //单据体
            var t = this.Body[bodyName].Rows.Count;//单据休行数
            var row = this.Body[bodyName].Rows[0];//单据体bodyName，第0行，第ItemNumber列

            //单据体单无格
            var cellBaseId = row[cellItemName].Id;
            var cellBaseNumber = row[cellItemName].Number;
            var cellBaseName = row[cellItemName].Name;
            var cellValue = row[cellItemName].Value;

            var cellToStringOrEmpty = row[cellItemName].ToStringOrDefault("123");
            var cellToDouble = row[cellItemName].ToDouble();
            var cellToInt = row[cellItemName].ToInt();
            var cellToIntOrDefault = row[cellItemName].ToIntOrDefault(0);
            var cellTryToIntOrDefault = row[cellItemName].TryToDoubleOrDefault(0);
            var cellToDataTime = row[cellItemName].ToDataTime();//转换为DateTime
            var cellTryToDateTimeOrDefault = row[cellItemName].TryToDateTimeOrDefault(DateTime.Now);//转换为DateTime，如果出现异常则返回当前时间

            //单据体赋值
            row[cellItemName].Number="01.01";
        }
    }
}
