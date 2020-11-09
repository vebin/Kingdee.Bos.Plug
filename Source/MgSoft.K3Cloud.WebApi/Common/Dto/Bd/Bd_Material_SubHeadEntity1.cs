using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    public class Bd_Material_SubHeadEntity1
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FStoreUnitID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FAuxUnitID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FUnitConvertDir { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FStockId { get; set; }


        //FStockPlaceId: {
        //    FSTOCKPLACEID__FF100001: {
        //        FNumber: 
        //    },
        //    FSTOCKPLACEID__FF100002: {
        //        FNumber: 
        //    }
        //},
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsLockStock { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsCycleCounting { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCountCycle { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FCountDay { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsMustCounting { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsBatchManage { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBatchRuleID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsKFPeriod { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsExpParToFlot { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FExpUnit { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FExpPeriod { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FOnlineLife { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FRefCost { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCurrencyId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsEnableMinStock { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsEnableMaxStock { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsEnableSafeStock { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsEnableReOrder { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FMinStock { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FSafeStock { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FReOrderGood { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FEconReOrderQty { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FMaxStock { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsSNManage { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsSNPRDTracy { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSNCodeRule { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSNUnit { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSNManageType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSNGenerateTime { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FBoxStandardQty { get; set; }
    }
}
