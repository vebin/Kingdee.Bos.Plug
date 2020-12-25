using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Pur
{
    /// <summary>
    /// 采购退料单DTO
    /// </summary>
    public class Pur_MrbSaveInputDto<Type_Pur_Mrb_FPurmrbFin, Type_Pur_Mrb_FPurmrbEntry>
        where Type_Pur_Mrb_FPurmrbFin : Pur_Mrb_FPurmrbFin
        where Type_Pur_Mrb_FPurmrbEntry : Pur_Mrb_FPurmrbEntry
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FBillTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FBillNo { get; set; }
        /// <summary>
        /// 退料日期(必填)
        /// </summary>
        [JsonRequired]
        public virtual DateTime? FDate { get; set; } = DateTime.Now;
        /// <summary>
        /// 退料类型（必填）
        /// </summary>
        [JsonRequired]
        public virtual string FMRTYPE { get; set; }
        /// <summary>
        /// 退料方式（必填）
        /// </summary>
        [JsonRequired]
        public virtual string FMRMODE { get; set; }
        /// <summary>
        /// 库存组织(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FStockOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FMRDeptId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSTOCKERGROUPID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCorrespondOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSTOCKERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FMRREASON { get; set; }
        /// <summary>
        /// 需求组织(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FRequireOrgId { get; set; }
        /// <summary>
        /// 采购组织(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FPurchaseOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPURCHASEDEPTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPURCHASERGROUPID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPURCHASERID { get; set; }
        /// <summary>
        /// 供应商(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FSupplierID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FDESCRIPTION { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FACCEPTORID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FAcceptAddress { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSettleId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCHARGEID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FOwnerTypeIdHead { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FOwnerIdHead { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FScanPoint { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FConfirmerId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FConfirmDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FScanBox { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FCDateOffsetUnit { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FCDateOffsetValue { get; set; }
        /// <summary>
        /// 补料方式
        /// </summary>
        [JsonRequired]
        public virtual string FREPLENISHMODE { get; set; } = "创建补料订单";
        //"FAcceptorContactID": {
        //    "FCONTACTNUMBER": ""
        //},
        /// <summary>
        /// 财务信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual Type_Pur_Mrb_FPurmrbFin FPURMRBFIN { get; set; }
        /// <summary>
        /// 明细信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Pur_Mrb_FPurmrbEntry> FPURMRBENTRY { get; set; }
    }
    public class Pur_MrbSaveInputDto : Pur_MrbSaveInputDto<Pur_Mrb_FPurmrbFin, Pur_Mrb_FPurmrbEntry>
    {
    }
}
