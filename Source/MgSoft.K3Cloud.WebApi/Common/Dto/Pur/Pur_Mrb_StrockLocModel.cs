using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Pur
{
    /// <summary>
    /// 仓位
    /// </summary>
    public class Pur_Mrb_StrockLocModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSTOCKLOCID__FF100001 { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public virtual FNumberProperty FSTOCKLOCID__FF100002 { get; set; }
    }
}
