using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Pur
{
    /// <summary>
    /// (采购订单)交货明细
    /// </summary>
    public class Pur_PurchaseOrder_EntryDeliveryPlan
    {
        public virtual int? FDetailId { get; set; }
        public virtual DateTime? FDeliveryDate_Plan { get; set; }
        public virtual decimal? FPlanQty { get; set; }
        public virtual string FELocation { get; set; }
        public virtual string FELocationAddress { get; set; }
        public virtual DateTime? FSUPPLIERDELIVERYDATE { get; set; }
        public virtual DateTime? FPREARRIVALDATE { get; set; }
        public virtual decimal? FTRLT { get; set; }
        public virtual decimal? FConfirmDeliQty { get; set; }
        public virtual DateTime? FConfirmDeliDate { get; set; }
        public virtual string FConfirmInfo { get; set; }
        public virtual FNumberProperty FELocationId { get; set; }
    }
}
