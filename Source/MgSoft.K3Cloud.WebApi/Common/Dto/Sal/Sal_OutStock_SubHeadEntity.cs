using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal
{
    public class Sal_OutStock_SubHeadEntity
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FEntryId { get; set; }
        /// <summary>
        /// 必填
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSettleOrgID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FLocalCurrID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FExchangeTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FExchangeRate { get; set; }
        /// <summary>
        /// 必填
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSettleCurrID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSettleTypeID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FReceiptConditionID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPriceListId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool FIsIncludedTax { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSETTLECustomerID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FOwnerSupplierID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FDiscountListId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool FIsPriceExcludeTax { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FThirdBillNo { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FThirdBillId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FThirdSrcType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FBuyerNick { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FReceiverName { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FReceiverMobile { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FReceiverCountry { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FReceiverState { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FReceiverCity { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FReceiverDistrict { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FReceiverAddress { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FReceiverPhone { get; set; }
    }
}
