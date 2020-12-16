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
        public long? FEntryID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FInStockType { get; set; }
        /// <summary>
        /// 物料编码(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FMATERIALID { get; set; }
        //"FAuxPropId": { "FAUXPROPID__FF100002": {"FNumber": ""}},
        /// <summary>
        /// 单位（必填）
        /// </summary>
        [JsonRequired]
        public FNumberProperty FUnitID { get; set; }
        /// <summary>
        /// 收货仓库(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FSTOCKID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StockLocModel FStockLocId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSTOCKSTATUSID { get; set; }
        /// <summary>
        /// 批号
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FLOT { get; set; }
        /// <summary>
        /// 实收数量
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FEntryNote { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBOMID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FPRODUCEDATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FMTONO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FExtAuxUnitId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FExtAuxUnitQty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FProjectNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOWNERTYPEID { get; set; }
        /// <summary>
        /// 货主(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FOWNERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FKEEPERTYPEID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FKEEPERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Type_Stk_Miscellaneous_SerialSubEntity> FSerialSubEntity { get; set; }
    }
    public class Stk_Miscellaneous_FEntity : Stk_Miscellaneous_FEntity<Stk_Miscellaneous_SerialSubEntity>
    { }
}
