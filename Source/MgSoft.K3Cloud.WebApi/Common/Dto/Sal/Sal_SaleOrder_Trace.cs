using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal
{

    /// <summary>
    /// (销售订单)物流跟踪明细
    /// </summary>
    /// <typeparam name="Type_Sal_SaleOrder_SaleOrderTraceDetail">物流详细信息</typeparam>
    public class Sal_SaleOrder_Trace<Type_Sal_SaleOrder_SaleOrderTraceDetail>
        where Type_Sal_SaleOrder_SaleOrderTraceDetail : Sal_SaleOrder_SaleOrderTraceDetail
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryID { get; set; }
        //"FLogComId": {
        //    "FCODE": ""
        //},
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCarryBillNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FPhoneNumber { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FDelTime { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FTraceStatus { get; set; }
        /// <summary>
        /// 物流详细信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Sal_SaleOrder_SaleOrderTraceDetail> FSalOrderTraceDetail { get; set; }
    }
    /// <summary>
    /// 物流跟踪明细
    /// </summary>
    public class Sal_SaleOrder_Trace : Sal_SaleOrder_Trace<Sal_SaleOrder_SaleOrderTraceDetail>
    { }
}
