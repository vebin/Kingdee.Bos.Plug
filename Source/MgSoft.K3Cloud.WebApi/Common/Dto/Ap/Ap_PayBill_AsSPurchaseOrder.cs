using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ap
{
    /// <summary>
    /// (付款单)关联采购订单
    /// </summary>
    public class Ap_PayBill_AsSPurchaseOrder
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
         public virtual long? FDetailID { get; set; }
    }
}
