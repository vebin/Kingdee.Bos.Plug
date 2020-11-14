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
        public virtual long? FLocationId { get; set; }
        /// <summary>
        /// 必填项
        /// </summary>
        public virtual string FLocName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FLocNewContact { get; set; }
        /// <summary>
        /// 必填项
        /// </summary>
        public virtual string FLocAddress { get; set; }
        /// <summary>
        /// 必填项
        /// </summary>
        public virtual string FLocMobile { get; set; }
    }
}
