using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Pur
{
    /// <summary>
    /// (采购订单)税务明细
    /// </summary>
    public class Pur_PurchaseOrder_TaxDetailSubEntity
    {
        public virtual long? FDetailID { get; set; }
        public virtual FNumberProperty FTaxRateId { get; set; }
        public virtual decimal? FTaxRate { get; set; }
    }
}
