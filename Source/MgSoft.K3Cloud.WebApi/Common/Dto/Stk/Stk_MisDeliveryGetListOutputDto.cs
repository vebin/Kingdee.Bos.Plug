using MgSoft.K3Cloud.WebApi.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Stk
{
    /// <summary>
    /// 其他入库单查询列表Dto
    /// </summary>
    public class Stk_MisDeliveryGetListOutputDto : GetListOutputDto
    {
        /// <summary>
        /// 分录内码
        /// </summary>
        [JsonProperty("FEntity_FEntryId")]
        public long FEntryId { get; set; }
    }
}
