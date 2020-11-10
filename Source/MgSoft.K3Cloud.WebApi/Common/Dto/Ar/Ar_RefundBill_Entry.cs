using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ar
{
    /// <summary>
    /// （收款退款单）退款单明细
    /// </summary>
    public class Ar_RefundBill_Entry
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSETTLETYPEID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPURPOSEID { get; set; }
        /// <summary>
        /// 应退金额(必填)
        /// </summary>
        [JsonRequired]
        public decimal? FREFUNDAMOUNTFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FREFUNDAMOUNTFOR_E { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FHANDLINGCHARGEFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FACCOUNTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FINNERACCOUNTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCashAccount { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSETTLENO { get; set; }
        /// <summary>
        /// 备注(必填)
        /// </summary>
        [JsonRequired]
        public string FNOTE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOpenAddressRec { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FRecType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FREFUNDAMOUNT_E { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FPOSTDATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISPOST { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSALEORDERNUMBER { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FMATERIALID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FMATERIALSEQ { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FORDERENTRYID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FRuZhangType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FEBMSG { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FPayType { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSwiftCode { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FNProvince { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FNCity { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FNDistrict { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FDistrictCode { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCountry { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBankDetail { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSignature { get; set; }

    }
}
