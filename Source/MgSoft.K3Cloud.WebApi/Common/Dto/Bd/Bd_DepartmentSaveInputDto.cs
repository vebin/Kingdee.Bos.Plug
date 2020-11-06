using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    /// <summary>
    /// 部门
    /// </summary>
    public class Bd_DepartmentSaveInputDto
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FDEPTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCreateOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FNumber { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FUseOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FHelpCode { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty  FParentID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FFullName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FEffectDate{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime?  FLapseDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty  FDeptProperty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FDescription { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FGroup { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool FIsCopyFlush { get; set; }
        /// <summary>
        /// SHR映射实体
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Bd_Department_SHRMapEntity FSHRMapEntity { get; set; }
    }
}
