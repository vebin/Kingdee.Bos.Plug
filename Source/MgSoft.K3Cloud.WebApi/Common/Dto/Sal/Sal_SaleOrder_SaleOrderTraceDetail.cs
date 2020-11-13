using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal
{
    /// <summary>
    /// (销售订单)物流详细信息
    /// </summary>
    public class Sal_SaleOrder_SaleOrderTraceDetail
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FDetailID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FTraceTime { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FTraceDetail { get; set; }
    }
}
