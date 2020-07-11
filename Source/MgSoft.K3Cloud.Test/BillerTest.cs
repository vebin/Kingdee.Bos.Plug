using Kingdee.BOS.Core.DynamicForm.PlugIn.Args;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.Test
{
    [Kingdee.BOS.Util.HotUpdate]
    public class BillerTest:Biller
    {
        public override void OnInitialize(InitializeEventArgs e)
        {
            base.OnInitialize(e);
        }

        public override void ButtonClick(ButtonClickEventArgs e)
        {
            this.View.ShowMessage("123123");
            //var headName = "";
            //var bodyName = "";
            //var cellName = "";
            //var cellItemName = "";

            ////单据头操作
            //var id = this.Heads["F_RVWT_Material"].Id;//基础资料，返回Id
            //var number = this.Heads["F_RVWT_Material"].Number;//基础资料，返回代码
            //var name = this.Heads["F_RVWT_Material"].Name;//基础资料，返回名称

            //var value = this.Heads["F_RVWT_Material"].Value;//返回DynamicObject对像
            //var toStringOrEmpty = this.Heads["F_RVWT_Text"].ToStringOrEmpty();//转字符串或返回空串
            //var toDouble = this.Heads["F_RVWT_Decimal"].ToDouble();//转为浮点数
            //var toInt = this.Heads["F_RVWT_INTEGER"].ToInt();//转为整数
            //var toIntOrDefault = this.Heads["F_RVWT_INTEGER"].ToIntOrDefault(0);//转为整数，如果为null则返回默认值
            //var tryToIntOrDefault = this.Heads["F_RVWT_INTEGER"].TryToIntOrDefault(0);//转为整数，如果异常则返回默认值
            //var toDataTime = this.Heads["F_RVWT_Date"].ToDataTime();//转换为DateTime
            //var tryToDateTimeOrDefault = this.Heads["F_RVWT_Date"].TryToDateTimeOrDefault(DateTime.Now);//转换为DateTime，如果出现异常则返回当前时间
            //var isNull = this.Heads["xxxx"].IsNull();

            ////单据头赋值
            //this.Heads[headName].Number = "01.01";//使用代码给基础资料赋值

            ////单据体
            //var t = this.Entities[bodyName].Rows.Count;//单据休行数
            //var row = this.Entities[bodyName].Rows[0];//单据体bodyName，第0行，第ItemNumber列

            ////单据体单无格
            //var cellBaseId = row[cellItemName].Id;
            //var cellBaseNumber = row[cellItemName].Number;
            //var cellBaseName = row[cellItemName].Name;
            //var cellValue = row[cellItemName].Value;

            //var cellToStringOrEmpty = row[cellItemName].ToStringOrDefault("FEntity");
            //var cellToDouble = row[cellItemName].ToDouble();
            //var cellToInt = row[cellItemName].ToInt();
            //var cellToIntOrDefault = row[cellItemName].ToIntOrDefault(0);
            //var cellTryToIntOrDefault = row[cellItemName].TryToDoubleOrDefault(0);
            //var cellToDataTime = row[cellItemName].ToDataTime();//转换为DateTime
            //var cellTryToDateTimeOrDefault = row[cellItemName].TryToDateTimeOrDefault(DateTime.Now);//转换为DateTime，如果出现异常则返回当前时间

            ////单据体赋值
            //row[cellItemName].Number = "01.01";
        }
    }
}