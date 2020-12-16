using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using MgSoft.K3Cloud.WebApi.Common.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Stk
{
    /// <summary>
    /// 其他入库单
    /// </summary>
    public class Stk_MiscellaneousSaveInputDto<Type_Stk_Miscellaneous_FEntity> where Type_Stk_Miscellaneous_FEntity : Stk_Miscellaneous_FEntity
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBillNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBillTypeID { get; set; }
        /// <summary>
        /// 库存组织(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FStockOrgId { get; set; }
        /// <summary>
        /// 库存方向(必填)
        /// </summary>
        [JsonRequired]
        public string FStockDirect { get; set; }
        /// <summary>
        /// 日期(必填)
        /// </summary>
        [JsonRequired]
        public DateTime? FDate { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSUPPLIERID { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FDEPTID { get; set; }
        //"FACCEPTANCE": {"FStaffNumber": ""},
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSTOCKERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSTOCKERGROUPID { get; set; }
        /// <summary>
        /// 货主类型(必填)
        /// </summary>
        [JsonRequired]
        public string FOwnerTypeIdHead { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FOwnerIdHead { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FNOTE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBaseCurrId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FScanBox { get; set; }
        /// <summary>
        /// 明细信息
        /// </summary>
        [JsonRequired]
        public List<Type_Stk_Miscellaneous_FEntity> FEntity { get; set; }
    }
    /// <summary>
    /// 其他入库单
    /// </summary>
    public class Stk_MiscellaneousSaveInputDto : Stk_MiscellaneousSaveInputDto<Stk_Miscellaneous_FEntity>
    { }
}
