using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ar
{
    /// <summary>
    /// (其他应收单)单据体
    /// </summary>
    public class Ar_OtherReceivable_Entry
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCOSTID { get; set; }
        /// <summary>
        /// 费用承担部门(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FCOSTDEPARTMENTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string INVOICETYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FNOTAXAMOUNTFOR { get; set; }
        /// <summary>
        /// 税额(必填)
        /// </summary>
        [JsonRequired]
        public decimal? FTAXAMOUNTFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FAMOUNTFOR_D { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FNOTAXAMOUNT_D { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FTAXAMOUNT_D { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCOMMENT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSourceBillNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FIVAmountFor { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FCREATEINVOICE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FEntryTaxRate { get; set; }
    }
}
