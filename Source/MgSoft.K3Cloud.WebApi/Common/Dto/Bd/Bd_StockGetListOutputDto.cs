using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    /// <summary>
    /// 仓库查询列表Dto
    /// </summary>
    public class Bd_StockGetListOutputDto
    {
        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonProperty("FNumber")]
        public string Number { get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("FName")]
        public string Name { get; set; }
    }
}
