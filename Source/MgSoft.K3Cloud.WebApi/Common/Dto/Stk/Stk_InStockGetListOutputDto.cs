using MgSoft.K3Cloud.WebApi.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Stk
{
    /// <summary>
    /// 采购入库单查询列表Dto
    /// </summary>
    public class Stk_InStockGetListOutputDto : GetListOutputDto
    {
        /// <summary>
        /// 分录内码
        /// </summary>
        [JsonProperty("FInStockEntry_FEntryId")]
        public long FEntryId { get; set; }
        /// <summary>
        /// 财务信息内码
        /// </summary>
        [JsonProperty("FInStockFin_FEntryId")]
        public long FInStockFinId { get; set; }
        /// <summary>
        /// 单据类型
        /// </summary>
        [JsonProperty("FBillTypeID")]
        public string FBillTypeID { get; set; }
    }
}
