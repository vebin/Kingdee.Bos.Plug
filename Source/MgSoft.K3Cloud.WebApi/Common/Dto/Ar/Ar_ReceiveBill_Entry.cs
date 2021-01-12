using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ar
{
    /// <summary>
    /// (收款单)明细信息
    /// </summary>
    public class Ar_ReceiveBill_Entry
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FEntryID { get; set; }
        /// <summary>
        /// 结算方式(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSETTLETYPEID { get; set; }
        /// <summary>
        /// 收款用途(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPURPOSEID { get; set; } = new FNumberProperty("SFKYT01_SYS");
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FRECEIVEITEMTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FRECEIVEITEM { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FSaleOrderID { get; set; }
        /// <summary>
        /// 应收金额
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FRECTOTALAMOUNTFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FRECAMOUNTFOR_E { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FSETTLEDISTAMOUNTFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FHANDLINGCHARGEFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FOVERUNDERAMOUNTFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FACCOUNTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FOPPOSITEBANKACCOUNT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FOPPOSITECCOUNTNAME { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FINNERACCOUNTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCashAccount { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FSETTLENO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FOPPOSITEBANKNAME { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FCOMMENT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FRECAMOUNT_E { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FPOSTDATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FMATERIALID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FSALEORDERNO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FMATERIALSEQ { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FORDERENTRYID { get; set; }
        /// <summary>
        /// 关联销售订单
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Ar_ReceiveBill_FAsSSalesOrder> FASSSALESORDER { get; set; }
    }
}
