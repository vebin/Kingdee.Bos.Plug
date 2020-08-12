using MgSoft.K3Cloud.Test.Dtos;
using MgSoft.K3Cloud.WebApi;
using MgSoft.K3Cloud.WebApi.Dto;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.Test
{
    public class TestApi: BaseApi
    {
        public TestApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public List<DeliveryNoticeListOutPutDto> GetList()
        {
            QueryListInputDto queryApiDto = new QueryListInputDto()
            {
                FormId = "SAL_DELIVERYNOTICE",
                //查找的字段，注意要配合indexFields进行修改
                FieldKeys = "FBillNo,FCUSTOMERID.FName,FCUSTOMERID.FTEL",
            };

            ///*序列化的顺序，需要配合FieldKeys进行修改
            // * 由于api返回的结果是一个扁平的数组
            // * indexFields的作用是，使行数组的位置与要序列化的字段作对应，例如:BillNo在第0位，把数组的第0位序列话给BillNo
            // */
            //string[] indexFields = new string[] { "BillNo", "CustomerName", "CustomerTel" };

            return this.GetList<DeliveryNoticeListOutPutDto>(queryApiDto);
        }
    }
}
