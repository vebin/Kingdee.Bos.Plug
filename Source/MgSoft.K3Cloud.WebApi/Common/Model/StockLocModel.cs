using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Model
{
    /// <summary>
    /// 仓位
    /// </summary>
    public class StockLocModel
    {
        /// <summary>
        /// 货架编码
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSTOCKLOCID__FF100001 { get; set; }
        /// <summary>
        /// 位置号编码
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSTOCKLOCID__FF100002 { get; set; }
    }
}
