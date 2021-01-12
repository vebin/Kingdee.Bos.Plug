using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using MgSoft.K3Cloud.WebApi.Common.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sp
{
    /// <summary>
    /// 简单生产领料
    /// </summary>
    /// <typeparam name="Type_Sp_PickMtrl_FEntity"></typeparam>
    public class Sp_PickMtrlSaveInputDto<Type_Sp_PickMtrl_FEntity> where Type_Sp_PickMtrl_FEntity : Sp_PickMtrl_FEntity
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FID{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBillNo{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBillType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FDate{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FDescription{ get; set; }
        /// <summary>
        /// 发料组织(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FStockOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FStockerGroupId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FStockerId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPickerId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCurrId { get; set; }
        /// <summary>
        /// 货主类型(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOwnerTypeId0{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FOwnerId0 { get; set; }
        /// <summary>
        /// 生产组织(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPrdOrgId { get; set; }
        /// <summary>
        /// 生产车间(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FWorkShopId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FTransferBizTypeId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FScanBox{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBizType{ get; set; }
        public List<Type_Sp_PickMtrl_FEntity> FEntity { get; set; }
    }
    /// <summary>
    /// 简单生产领料单
    /// </summary>
    public class Sp_PickMtrlSaveInputDto : Sp_PickMtrlSaveInputDto<Sp_PickMtrl_FEntity>
    { }
}
