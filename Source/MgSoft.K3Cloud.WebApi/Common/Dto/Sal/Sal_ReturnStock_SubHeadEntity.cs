using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal_ReturnStock
{
    /// <summary>
    /// (销售退货单)财务信息
    /// </summary>
    public class Sal_ReturnStock_SubHeadEntity
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryId { get; set; }
        /// <summary>
        /// 结算币别(必填项)
        /// </summary>
        public FNumberProperty FSettleCurrId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FThirdBillNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FThirdBillId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FThirdSrcType { get; set; }
        /// <summary>
        /// 结算组织(必填项)
        /// </summary>
        public FNumberProperty FSettleOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSettleTypeId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FChageCondition { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPriceListId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FDiscountListId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FLocalCurrId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FExchangeTypeId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal FExchangeRate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBuyerNick { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FReceiverAddress { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FReceiverName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FReceiverMobile { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FReceiverCountry { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FReceiverState { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FReceiverCity { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FReceiverDistrict { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FReceiverPhone { get; set; }
    }
}
