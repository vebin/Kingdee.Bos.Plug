using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using MgSoft.K3Cloud.WebApi.Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sp
{
    /// <summary>
    /// (简单生产领料单)明细
    /// </summary>
    public class Sp_PickMtrl_FEntity<Type_Sp_PickMtrl_SerialSubEntity> where Type_Sp_PickMtrl_SerialSubEntity : Sp_PickMtrl_SerialSubEntity
    {
        public long? FEntryID { get; set; }
        public FNumberProperty FMaterialId { get; set; }
        //"FAuxPropId": {},
        public FNumberProperty FBomId { get; set; }
        public FNumberProperty FUnitID { get; set; }
        public decimal? FAppQty { get; set; }
        public decimal? FActualQty { get; set; }
        public FNumberProperty FStockId { get; set; }
        public StockLocModel FStockLocId { get; set; }
        public FNumberProperty FLot { get; set; }
        public FNumberProperty FProductId { get; set; }
        public string FProductNo { get; set; }
        public bool? FIsAffectCost { get; set; }
        public FNumberProperty FPRODUCTGROUPID { get; set; }
        public FNumberProperty FStockUnitId { get; set; }
        public decimal? FStockActualQty { get; set; }
        public string FOwnerTypeId { get; set; }
        public FNumberProperty FEntryWorkShopId { get; set; }
        public FNumberProperty FExtAuxUnitId { get; set; }
        public decimal? FExtAuxUnitQty { get; set; }
        public decimal? FPrice { get; set; }
        public decimal? FAmount { get; set; }
        public string FParentOwnerTypeId { get; set; }
        public FNumberProperty FParentOwnerId { get; set; }
        public FNumberProperty FBaseUnitId { get; set; }
        public string FServiceContext { get; set; }
        public decimal? FBaseActualQty { get; set; }
        public FNumberProperty FOwnerId { get; set; }
        public FNumberProperty FStockStatusId { get; set; }
        public DateTime? FProduceDate { get; set; }
        public FNumberProperty FSecUnitId { get; set; }
        public decimal? FSecActualQty { get; set; }
        public string FEntrtyMemo { get; set; }
        public string FMtoNo { get; set; }
        public decimal? FBaseAppQty { get; set; }
        public string FKeeperTypeId { get; set; }
        public FNumberProperty FKeeperId { get; set; }
        public DateTime? FExpiryDate { get; set; }
        public List<Type_Sp_PickMtrl_SerialSubEntity> FSerialSubEntity { get; set; }
    }
    public class Sp_PickMtrl_FEntity : Sp_PickMtrl_FEntity<Sp_PickMtrl_SerialSubEntity>
    { }
}
