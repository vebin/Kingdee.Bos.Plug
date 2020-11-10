using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ar
{
    /// <summary>
    /// 关联销售订单
    /// </summary>
    public class Ar_ReceiveBill_FAsSSalesOrder
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
       public long? FDetailID { get; set; }
    }
}
