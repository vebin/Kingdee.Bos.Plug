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
        public virtual long? FEntryID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCOSTID { get; set; }
        /// <summary>
        /// 费用承担部门(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCOSTDEPARTMENTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FINVOICETYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FEntryTaxRate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FNOTAXAMOUNTFOR { get; set; }
        /// <summary>
        /// 税额(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FTAXAMOUNTFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FTOTALAMOUNTFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FNOTSETTLEAMOUNTFOR_D { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FNOTAXAMOUNT_D { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FTAXAMOUNT_D { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FCOMMENT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FSourceBillNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FCREATEINVOICE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FIVAmountFor { get; set; }
        /// <summary>
        /// 关联付款子单体
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Ap_OtherPayable_PaySubEntity> FPaySubEntity { get; set; }
    }
    public class Ap_OtherPayable_Entry : Ap_OtherPayable_Entry<Ap_OtherPayable_PaySubEntity>
    { }
}
