using MgSoft.K3Cloud.WebApi.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sp
{
    /// <summary>
    /// 简单生产领料单列表查询Dto
    /// </summary>
    public class Sp_PickMtrlGetListOutputDto : GetListOutputDto
    {
        /// <summary>
        /// 分录内码
        /// </summary>
        [JsonProperty("FEntity_FEntryId")]
        public long? FEntryId { get; set; }
        /// <summary>
        /// 物料编码
        /// </summary>
        [JsonProperty("FMaterialId.FNumber")]
        public string MaterialNumber { get; set; }
    }
}
