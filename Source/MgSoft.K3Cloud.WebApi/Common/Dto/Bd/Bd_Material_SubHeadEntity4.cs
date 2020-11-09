using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    public class Bd_Material_SubHeadEntity4
    {

        public long? FEntryId { get; set; }
        public string FPlanMode { get; set; }
        public decimal? FBaseVarLeadTimeLotSize { get; set; }
        public string FPlanningStrategy { get; set; }
        public FNumberProperty FMfgPolicyId { get; set; }
        public string FOrderPolicy { get; set; }
        public FNumberProperty FPlanWorkshop { get; set; }
        public int? FFixLeadTime { get; set; }
        public string FFixLeadTimeType { get; set; }
            public int? FVarLeadTime { get; set; }
            public string FVarLeadTimeType { get; set; }
            public int? FCheckLeadTime { get; set; }
            public string FCheckLeadTimeType { get; set; }
            public string FOrderIntervalTimeType { get; set; }
            public int? FOrderIntervalTime { get; set; }
            public decimal? FMaxPOQty { get; set; }
            public decimal? FMinPOQty { get; set; }
            public decimal? FIncreaseQty { get; set; }
        public decimal? FEOQ { get; set; }
        public decimal? FVarLeadTimeLotSize { get; set; }
        public decimal? FPlanIntervalsDays { get; set; }
        public decimal? FPlanBatchSplitQty { get; set; }
        public decimal? FRequestTimeZone { get; set; }
        public decimal? FPlanTimeZone { get; set; }
        public FNumberProperty FPlanGroupId { get; set; }
        public FNumberProperty FATOSchemeId { get; set; }
        public FNumberProperty FPlanerID { get; set; }
        public int? FCanLeadDays { get; set; }
        public bool? FIsMrpComReq { get; set; }
            public int? FLeadExtendDay { get; set; }
           public string FReserveType { get; set; }
            public decimal? FPlanSafeStockQty { get; set; }
            public bool? FAllowPartAhead { get; set; }
            public int? FCanDelayDays { get; set; }
            public int FDelayExtendDay { get; set; }
            public bool? FAllowPartDelay { get; set; }
            public string FPlanOffsetTimeType { get; set; }
            public int? FPlanOffsetTime { get; set; }
            public FNumberProperty FSupplySourceId { get; set; }
            public FNumberProperty FTimeFactorId { get; set; }
            public FNumberProperty FQtyFactorId { get; set; }
            public FNumberProperty FProductLine { get; set; }
            public decimal? FWriteOffQty { get; set; }
            public FNumberProperty FPlanIdent { get; set; }
            public FNumberProperty FProScheTrackId { get; set; }
            public decimal? FDailyOutQty { get; set; }
    }
}
