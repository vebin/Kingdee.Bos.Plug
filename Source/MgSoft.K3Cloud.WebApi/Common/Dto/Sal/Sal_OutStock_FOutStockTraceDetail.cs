using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal
{
    /// <summary>
    /// 物流详细信息
    /// </summary>
    public class Sal_OutStock_FOutStockTraceDetail
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FDetailID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FTraceTime { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FTraceDetail { get; set; }
    }
}
