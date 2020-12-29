using MgSoft.K3Cloud.WebApi.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sp
{
    /// <summary>
    /// 简单生产入库单列表查询Dto
    /// </summary>
    public class Sp_InstockGetListOutputDto : GetListOutputDto
    {
        [JsonProperty("FEntity_FEntryId")]
        public long? FEntryId { get; set; }
    }
}
