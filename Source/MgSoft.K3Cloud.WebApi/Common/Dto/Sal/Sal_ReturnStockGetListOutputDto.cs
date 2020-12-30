using MgSoft.K3Cloud.WebApi.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal
{
    /// <summary>
    /// 销售退货单列表查询Dto
    /// </summary>
    public class Sal_ReturnStockGetListOutputDto : GetListOutputDto
    {
        /// <summary>
        /// 分录内码
        /// </summary>
        [JsonProperty("FEntity_FEntryId")]
        public virtual long FEntryId { get; set; }
        /// <summary>
        /// 数据状态
        /// </summary>
        [JsonProperty("FDocumentStatus")]
        public virtual string FDocumentStatus { get; set; }
    }
}
