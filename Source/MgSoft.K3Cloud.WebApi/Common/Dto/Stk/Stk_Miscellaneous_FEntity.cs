using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using MgSoft.K3Cloud.WebApi.Common.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Stk
{
    /// <summary>
    /// (其他入库单)明细
    /// </summary>
    public class Stk_Miscellaneous_FEntity<Type_Stk_Miscellaneous_SerialSubEntity>
        where Type_Stk_Miscellaneous_SerialSubEntity : Stk_Miscellaneous_SerialSubEntity
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FEntryID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FInStockType { get; set; }
        /// <summary>
        /// 物料编码(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FMATERIALID { get; set; }
        //"FAuxPropId": { "FAUXPROPID__FF100002": {"FNumber": ""}},
        /// <summary>
        /// 单位（必填）
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FUnitID { get; set; }
        /// <summary>
        /// 收货仓库(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSTOCKID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual StockLocModel FStockLocId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSTOCKSTATUSID { get; set; }
        /// <summary>
        /// 批号
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FLOT { get; set; }
        /// <summary>
        /// 实收数量
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FEntryNote { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FBOMID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FPRODUCEDATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FMTONO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FExtAuxUnitId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FExtAuxUnitQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FProjectNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FOWNERTYPEID { get; set; }
        /// <summary>
        /// 货主(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FOWNERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FKEEPERTYPEID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FKEEPERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Stk_Miscellaneous_SerialSubEntity> FSerialSubEntity { get; set; }
    }
    public class Stk_Miscellaneous_FEntity : Stk_Miscellaneous_FEntity<Stk_Miscellaneous_SerialSubEntity>
    { }
}
