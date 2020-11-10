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
        public long? FID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBillTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBillNo { get; set; }
        /// <summary>
        /// 退料日期(必填)
        /// </summary>
        [JsonRequired]
        public DateTime? FDate { get; set; } = DateTime.Now;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FMRTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FMRMODE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FStockOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FMRDeptId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSTOCKERGROUPID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCorrespondOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSTOCKERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FMRREASON { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FRequireOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPurchaseOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPURCHASEDEPTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPURCHASERGROUPID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPURCHASERID { get; set; }
        /// <summary>
        /// 供应商(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FSupplierID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FDESCRIPTION { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FACCEPTORID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FAcceptAddress { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSettleId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCHARGEID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOwnerTypeIdHead { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FOwnerIdHead { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FScanPoint { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FConfirmerId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FConfirmDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FScanBox { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCDateOffsetUnit { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FCDateOffsetValue { get; set; }
        /// <summary>
        /// 补料方式
        /// </summary>
        [JsonRequired]
        public string FREPLENISHMODE { get; set; } = "创建补料订单";
        //"FAcceptorContactID": {
        //    "FCONTACTNUMBER": ""
        //},
        /// <summary>
        /// 财务信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Pur_Mrb_FPurmrbFin FPURMRBFIN { get; set; }
        /// <summary>
        /// 明细信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Pur_Mrb_FPurmrbEntry> FPURMRBENTRY { get; set; }
    }
    public class Pur_MrbSaveInputDto : Pur_MrbSaveInputDto<Pur_Mrb_FPurmrbFin, Pur_Mrb_FPurmrbEntry>
    {
    }
}
