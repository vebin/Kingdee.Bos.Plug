using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    public class Bd_Material_SubHeadEntity5
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long FEntryId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FWorkShopId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FProduceUnitId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FFinishReceiptOverRate { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FFinishReceiptShortRate { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FProduceBillType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FOrgTrustBillType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsSNCarryToParent { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool FIsProductLine { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBOMUnitId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FLOSSPERCENT { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FConsumVolatility { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsMainPrd { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsCoby { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsECN { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FIssueType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBKFLTime { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPickStockId { get; set; }

        //"FPickBinId": {
        //    "FPICKBINID__FF100001": {
        //        "FNumber": ""
        //    },
        //    "FPICKBINID__FF100002": {
        //        "FNumber": ""
        //    }
        //},
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOverControlMode { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FMinIssueQty { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISMinIssueQty { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsKitting { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsCompleteSet { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FDefaultRouting { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FStdLaborPrePareTime { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FStdLaborProcessTime { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FStdMachinePrepareTime { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FStdMachineProcessTime { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FMinIssueUnitId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FMdlId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FMdlMaterialId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FStandHourUnitId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBackFlushType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FFIXLOSS { get; set; }
    }
}
