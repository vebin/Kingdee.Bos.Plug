using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    /// <summary>
    /// (供应商)商务信息
    /// </summary>
    public class Bd_Supplier_BusinessInfo
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryId { get; set; }
        //"FFreezeOperator": {
        //    "FUserID": ""
        //},
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime FFreezeDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPurchaserGroupId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FParentSupplierId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSettleTypeId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPRICELISTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FDiscountListId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FProviderId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FWipStockId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool FVmiBusiness { get; set; }
        //"FWipStockPlaceId": {
        //    "FWIPSTOCKPLACEID__FF100001": {
        //        "FNumber": ""
        //    },
        //    "FWIPSTOCKPLACEID__FF100002": {
        //        "FNumber": ""
        //    }
        //},
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FVmiStockId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool FEnableSL { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal FDepositRatio { get; set; }
    }
}
