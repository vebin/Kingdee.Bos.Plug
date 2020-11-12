using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ap
{
    /// <summary>
    /// (其他应付单)明细
    /// </summary>
    public class Ap_OtherPayable_Entry<Type_Ap_OtherPayable_PaySubEntity>
        where Type_Ap_OtherPayable_PaySubEntity : Ap_OtherPayable_PaySubEntity
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
        public string FINVOICETYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FEntryTaxRate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FNOTAXAMOUNTFOR { get; set; }
        /// <summary>
        /// 税额(必填)
        /// </summary>
        [JsonRequired]
        public decimal? FTAXAMOUNTFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FTOTALAMOUNTFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FNOTSETTLEAMOUNTFOR_D { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FNOTAXAMOUNT_D { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FTAXAMOUNT_D { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCOMMENT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSourceBillNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FCREATEINVOICE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FIVAmountFor { get; set; }
        /// <summary>
        /// 关联付款子单体
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ap_OtherPayable_PaySubEntity> FPaySubEntity { get; set; }
    }
    public class Ap_OtherPayable_Entry : Ap_OtherPayable_Entry<Ap_OtherPayable_PaySubEntity>
    { }
}
