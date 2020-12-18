using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sp
{
    /// <summary>
    /// 简单生产入库
    /// </summary>
    /// <typeparam name="Type_Sp_Instock_FEntity">明细</typeparam>
    public class Sp_InstockSaveInputDto<Type_Sp_Instock_FEntity> where Type_Sp_Instock_FEntity : Sp_Instock_FEntity
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FID{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FBillNo{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FBillType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FDate{ get; set; }
        /// <summary>
        /// 入库组织(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FStockOrgId { get; set; }
        /// <summary>
        /// 生产组织(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FPrdOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockerGroupId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockerId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCurrId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FOwnerTypeId0{ get; set; }
        /// <summary>
        /// 货主(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FOwnerId0 { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FDescription{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FTransferBizTypeId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FScanBox{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Sp_Instock_FEntity> FEntity { get; set; }
    }
    /// <summary>
    /// 简单生产入库单
    /// </summary>
    public class Sp_InstockSaveInputDto : Sp_InstockSaveInputDto<Sp_Instock_FEntity>
    { }
}
