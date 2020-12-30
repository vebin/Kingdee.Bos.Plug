using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using MgSoft.K3Cloud.WebApi.Common.Model;
using Newtonsoft.Json;
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
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryID { get; set; }
        /// <summary>
        /// 物料编码(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FMaterialId { get; set; }
        //"FAuxPropId": {},
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBomId { get; set; }
        /// <summary>
        /// 计量单位(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FUnitID { get; set; }
        /// <summary>
        /// 申请数量
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FAppQty { get; set; }
        /// <summary>
        /// 实发数量
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FActualQty { get; set; }
        /// <summary>
        /// 仓库(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FStockId { get; set; }
        /// <summary>
        /// 仓位
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StockLocModel FStockLocId { get; set; }
        /// <summary>
        /// 批号
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FLot { get; set; }
        /// <summary>
        /// 生产对象(影响成本计算)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FProductId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FProductNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsAffectCost { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPRODUCTGROUPID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FStockUnitId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FStockActualQty { get; set; }
        /// <summary>
        /// 货主类型
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOwnerTypeId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FEntryWorkShopId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FExtAuxUnitId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FExtAuxUnitQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FPrice { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FAmount { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FParentOwnerTypeId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FParentOwnerId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBaseUnitId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FServiceContext { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FBaseActualQty { get; set; }
        /// <summary>
        /// 货主(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FOwnerId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FStockStatusId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FProduceDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSecUnitId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FSecActualQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FEntrtyMemo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FMtoNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FBaseAppQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FKeeperTypeId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FKeeperId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FExpiryDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Type_Sp_PickMtrl_SerialSubEntity> FSerialSubEntity { get; set; }
    }
    public class Sp_PickMtrl_FEntity : Sp_PickMtrl_FEntity<Sp_PickMtrl_SerialSubEntity>
    { }
}
