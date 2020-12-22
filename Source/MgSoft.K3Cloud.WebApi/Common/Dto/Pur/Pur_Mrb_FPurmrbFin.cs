using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Pur
{
    /// <summary>
    /// (采购退料单) 财务信息
    /// </summary>
    public class Pur_Mrb_FPurmrbFin
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FEntryId { get; set; }
        /// <summary>
        /// 结算组织(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FSettleOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSETTLETYPEID { get; set; }
        /// <summary>
        /// 结算币别(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FSettleCurrId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPAYCONDITIONID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FIsIncludedTax { get; set; }
        /// <summary>
        /// 定价时点(必填)
        /// </summary>
        [JsonRequired]
        public virtual string FPRICETIMEPOINT { get; set; } = "系统日期";
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPRICELISTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FDISCOUNTLISTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FLOCALCURRID { get; set; }
        /// <summary>
        /// 汇率类型
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FEXCHANGETYPEID { get; set; }
        /// <summary>
        /// 汇率
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FEXCHANGERATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISPRICEEXCLUDETAX { get; set; }

    }
}
