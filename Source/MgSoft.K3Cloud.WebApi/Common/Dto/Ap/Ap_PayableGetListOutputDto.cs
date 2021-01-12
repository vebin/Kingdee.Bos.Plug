using MgSoft.K3Cloud.WebApi.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ap
{
    /// <summary>
    /// 应付单列表查询Dto
    /// </summary>
    public class Ap_PayableGetListOutputDto : GetListOutputDto
    {
        /// <summary>
        /// 明细分录内码
        /// </summary>
        [JsonProperty("FEntityDetail_FEntryId")]
        public long FEntryId { get; set; }
    }
}
