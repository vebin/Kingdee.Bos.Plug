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
        public long? FEntryID { get; set; }
        /// <summary>
        /// 结算方式(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FSETTLETYPEID { get; set; }
        /// <summary>
        /// 收款用途(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FPURPOSEID { get; set; } = new FNumberProperty("SFKYT01_SYS");
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FRECEIVEITEMTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FRECEIVEITEM { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FSaleOrderID { get; set; }
        /// <summary>
        /// 应收金额
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FRECTOTALAMOUNTFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FRECAMOUNTFOR_E { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FSETTLEDISTAMOUNTFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FHANDLINGCHARGEFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FOVERUNDERAMOUNTFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FACCOUNTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOPPOSITEBANKACCOUNT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOPPOSITECCOUNTNAME { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FINNERACCOUNTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCashAccount { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSETTLENO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOPPOSITEBANKNAME { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCOMMENT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FRECAMOUNT_E { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FPOSTDATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FMATERIALID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSALEORDERNO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FMATERIALSEQ { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FORDERENTRYID { get; set; }
        /// <summary>
        /// 关联销售订单
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ar_ReceiveBill_FAsSSalesOrder> FASSSALESORDER { get; set; }
    }
}
