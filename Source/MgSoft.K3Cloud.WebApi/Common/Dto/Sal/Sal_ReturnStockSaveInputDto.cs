using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal_ReturnStock
{
    /// <summary>
    /// 销售退货单
    /// </summary>
    /// <typeparam name="Type_Sal_ReturnStock_SubHeadEntity"></typeparam>
    /// <typeparam name="Type_Sal_RetrunStock_FEntity"></typeparam>
    public class Sal_ReturnStockSaveInputDto<Type_Sal_ReturnStock_SubHeadEntity, Type_Sal_RetrunStock_FEntity>
        where Type_Sal_ReturnStock_SubHeadEntity : Sal_ReturnStock_SubHeadEntity
        where Type_Sal_RetrunStock_FEntity : Sal_ReturnStock_FEntity
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBillTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBillNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FDate { get; set; }
        /// <summary>
        /// 销售组织(必填项)
        /// </summary>
        public FNumberProperty FSaleOrgId { get; set; }
        /// <summary>
        /// 退货客户(必填项)
        /// </summary>        
        public FNumberProperty FRetcustId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSaledeptid { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FReturnReason { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FHeadLocId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCorrespondOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FTransferBizType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSaleGroupId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSalesManId { get; set; }
        /// <summary>
        /// 库存组织(必填项)
        /// </summary>
        public FNumberProperty FStockOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FStockDeptId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FStockerGroupId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FStockerId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FHeadNote { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FReceiveCustId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FReceiveAddress { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSettleCustId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNameProperty FReceiveCusContact { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPayCustId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOwnerTypeIdHead { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FOwnerIdHead { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FScanBox { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCDateOffsetUnit { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal FCDateOffsetValue { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool FIsTotalServiceOrCost { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSHOPNUMBER { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FGYDATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSALECHANNEL { get; set; }
        /// <summary>
        /// 财务信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Sal_ReturnStock_SubHeadEntity SubHeadEntity { get; set; }
        /// <summary>
        /// 明细信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Sal_ReturnStock_FEntity> FEntity { get; set; }

    }
    public class Sal_ReturnStockSaveInputDto : Sal_ReturnStockSaveInputDto<Sal_ReturnStock_SubHeadEntity, Sal_ReturnStock_FEntity>
    { }
}
