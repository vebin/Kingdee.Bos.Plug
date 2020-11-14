using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal_ReturnStock
{
    /// <summary>
    /// (销售退库单)序列号子单据体
    /// </summary>
    public virtual class Sal_ReturnStock_FSerialSubEntity
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FDetailID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FSerialNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FSerialNote { get; set; }

    }
}
