using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ap
{

    /// <summary>
    /// （付款单）付款单明细
    /// </summary>
    public class Ap_PayBill_Entry<Type_Ap_PayBill_AsSPurchaseOrder> 
        where Type_Ap_PayBill_AsSPurchaseOrder : Ap_PayBill_AsSPurchaseOrder
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryID { get; set; }
        /// <summary>
        /// 结算方式(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FSETTLETYPEID { get; set; }
        /// <summary>
        /// 付款用途(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FPURPOSEID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FPAYITEMTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FPAYITEM { get; set; }
        /// <summary>
        /// 应付金额(必填)
        /// </summary>
        [JsonRequired]
        public decimal? FPAYTOTALAMOUNTFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FPAYAMOUNTFOR_E { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FSETTLEDISTAMOUNTFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FSETTLEPAYAMOUNTFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FOVERSHORTAGEFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FHANDLINGCHARGEFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FREALPAYAMOUNTFOR_D { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FACCOUNTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FINNERACCOUNTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOPPOSITEBANKACCOUNT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOPPOSITECCOUNTNAME { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOPPOSITEBANKNAME { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCashAccount { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSETTLENO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCOMMENT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FPURCHASEORDERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOpenAddressRec { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNameProperty FProvince { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FRecType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNameProperty FCity { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCNAPS { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNameProperty FDistrict { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNameProperty FBankTypeRec { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCOSTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FEXPENSEDEPTID_E { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FPAYAMOUNT_E { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FPOSTDATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FMATERIALID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPRICEUNITID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FPRICE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FPURCHASEORDERNO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FMATERIALSEQ { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FORDERENTRYID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FRuZhangType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FPayType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSwiftCode { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FNProvince { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FTaxAmt { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FNCity { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FNDistrict { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FDistrictCode { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBankDetail { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCountry { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSignature { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FGYSALEORDERNO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ap_PayBill_AsSPurchaseOrder> FASSPURCHASEORDER { get; set; }
    }
    public class Ap_PayBill_Entry : Ap_PayBill_Entry<Ap_PayBill_AsSPurchaseOrder>
    { 
    }
}
