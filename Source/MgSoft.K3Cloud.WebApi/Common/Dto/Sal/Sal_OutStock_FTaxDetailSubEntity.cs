using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal
{
    /// <summary>
    /// 税务明细
    /// </summary>
    public class Sal_OutStock_FTaxDetailSubEntity
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FDetailID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FTaxRate {get; set;}
    }
}
