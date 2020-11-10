using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    /// <summary>
    /// (供应商)组织信息
    /// </summary>
    public class Bd_Supplier_LocationInfo
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FLocationId { get; set; }
        /// <summary>
        /// 必填项
        /// </summary>
        public string FLocName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FLocNewContact { get; set; }
        /// <summary>
        /// 必填项
        /// </summary>
        public string FLocAddress { get; set; }
        /// <summary>
        /// 必填项
        /// </summary>
        public string FLocMobile { get; set; }
    }
}
