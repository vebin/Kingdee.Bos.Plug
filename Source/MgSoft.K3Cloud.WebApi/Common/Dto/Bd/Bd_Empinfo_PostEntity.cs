using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    /// <summary>
    /// （员工）岗位信息
    /// </summary>
    public class Bd_Empinfo_PostEntity
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FENTRYID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FWorkOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPostDept { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPost { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FStaffStartDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool FIsFirstPost { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal FStaffDetails { get; set; }
    }
}
