using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    /// <summary>
    /// 员工
    /// </summary>
    public class Bd_EmpinfoSaveInputDto<Type_Bd_Empinfo_PostEntity, Type_Bd_Empinfo_BankInfo> 
        where Type_Bd_Empinfo_PostEntity : Bd_Empinfo_PostEntity
        where Type_Bd_Empinfo_BankInfo : Bd_Empinfo_BankInfo
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FStaffNumber { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FMobile { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FTel { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FEmail { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FDescription { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FAddress { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FUseOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCreateOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBranchID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool FCreateSaler { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool FCreateUser { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool FCreateCashie { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCashierGrp { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSalerId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCashierId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FUserId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPostId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FJoinDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FUniportalNo { get; set; }
        /// <summary>
        /// SHR映射实体
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Bd_Empinfo_SHRMapEntity FSHRMapEntity { get; set; }
        /// <summary>
        /// 岗位信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Bd_Empinfo_PostEntity> FPostEntity { get; set; }
        /// <summary>
        /// 财务信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Bd_Empinfo_BankInfo> FBankInfo { get; set; }
    }
    public class Bd_EmpinfoSaveInputDto : Bd_EmpinfoSaveInputDto<Bd_Empinfo_PostEntity, Bd_Empinfo_BankInfo>
    { }
}
