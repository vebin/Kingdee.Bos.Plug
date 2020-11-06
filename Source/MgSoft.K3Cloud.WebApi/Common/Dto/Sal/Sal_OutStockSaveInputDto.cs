using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal
{
    /// <summary>
    /// 销售出库单DTO
    /// </summary>
    /// <typeparam name="FEntity">明细信息</typeparam>
    /// <typeparam name="Sal_OutStock_FOutStockTrace">物流跟踪明细</typeparam>
    public class Sal_OutStockSaveInputDto<
        Type_Sal_SubHeadEntity,
        Type_Sal_OutStock_FEntity,
        Type_Sal_OutStock_FOutStockTrace>
        where Type_Sal_SubHeadEntity : Sal_OutStock_SubHeadEntity
        where Type_Sal_OutStock_FEntity : Sal_OutStock_FEntity<Sal_OutStock_FTaxDetailSubEntity, Sal_OutStock_FSerialSubEntity>
        where Type_Sal_OutStock_FOutStockTrace : Sal_OutStock_FOutStockTrace<Sal_OutStock_FOutStockTraceDetail>
    {
        /// <summary>
        /// 主键
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FID { get; set; }

        /// <summary>
        /// 必填
        /// </summary>
        public virtual FNumberProperty FBillTypeID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FBillNo { get; set; }

        /// <summary>
        /// 必填
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSaleOrgId { get; set; }

        /// <summary>
        /// 必填
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime FDate { get; set; }

        /// <summary>
        /// 必填
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockOrgId { get; set; }

        /// <summary>
        /// 必填
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public virtual FNumberProperty FCustomerID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FDeliveryDeptID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSaleDeptID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockerGroupID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FStockerID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSalesGroupID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSalesManID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCarrierID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCarriageNO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FReceiverID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSettleID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPayerID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FOwnerTypeIdHead { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FOwnerIdHead { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FReceiveAddress { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FHeadLocationId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCorrespondOrgId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNameProperty FReceiverContactID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FLinkPhone { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FLinkMan { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FBranchId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FScanBox { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FCDateOffsetUnit { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FCDateOffsetValue { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FPlanRecAddress { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool FIsTotalServiceOrCost { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FNote { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FSHOPNUMBER { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FGYDATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FSALECHANNEL { get; set; }

        /// <summary>
        /// 财务信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual Type_Sal_SubHeadEntity SubHeadEntity { get; set; }

        /// <summary>
        /// 明细信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Sal_OutStock_FEntity> FEntity { get; set; }

        /// <summary>
        /// 物流跟踪明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Sal_OutStock_FOutStockTrace> FOutStockTrace { get; set; }


    }
    public class Sal_OutStockSaveInputDto :
            Sal_OutStockSaveInputDto<
                Sal_OutStock_SubHeadEntity,
                Sal_OutStock_FEntity<Sal_OutStock_FTaxDetailSubEntity, Sal_OutStock_FSerialSubEntity>,
                Sal_OutStock_FOutStockTrace<Sal_OutStock_FOutStockTraceDetail>
                >
    {
    }
}
