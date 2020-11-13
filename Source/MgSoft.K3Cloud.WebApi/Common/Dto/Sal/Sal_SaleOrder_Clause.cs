using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal
{
    /// <summary>
    /// (销售订单)订单条款
    /// </summary>
    public class Sal_SaleOrder_Clause
    {        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FClauseId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FClauseDesc { get; set; }
    }
}
