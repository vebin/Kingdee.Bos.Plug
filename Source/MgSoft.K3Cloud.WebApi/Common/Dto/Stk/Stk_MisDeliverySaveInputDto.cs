using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using MgSoft.K3Cloud.WebApi.Common.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Stk
{
    /// <summary>
    /// 其他出库单
    /// </summary>
    public class Stk_MisDeliverySaveInputDto<Type_Stk_MisDelivery_FEntity> 
        where Type_Stk_MisDelivery_FEntity : Stk_MisDelivery_FEntity
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FID{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FBillNo{ get; set; }
        /// <summary>
        /// 单据类型(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FBillTypeID { get; set; }
        /// <summary>
        /// 库存组织(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FStockOrgId { get; set; }
        /// <summary>
        /// 领用组织
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPickOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FStockDirect{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FDate{ get; set; }
        /// <summary>
        /// 客户
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCustId { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FDeptId { get; set; }
        //"FPickerId ": {"FStaffNumber": ""},
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockerId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockerGroupId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FBizType{ get; set; }
        /// <summary>
        /// 货主类型(必填)
        /// </summary>
        [JsonRequired]
        public virtual string FOwnerTypeIdHead{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FOwnerIdHead { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FNote{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FBaseCurrId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FScanBox{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Stk_MisDelivery_FEntity> FEntity { get; set; }
    }
    public class Stk_MisDeliverySaveInputDto : Stk_MisDeliverySaveInputDto<Stk_MisDelivery_FEntity>
    { }
}
