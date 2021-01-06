using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    /// <summary>
    /// 物料列表查询Dto
    /// </summary>
    public class Bd_MaterialGetListOutputDto
    {
        /// <summary>
        /// 物料编码
        /// </summary>
        [JsonProperty("FNumber")]
        public string Number { get; set; }
        /// <summary>
        /// 物料名称
        /// </summary>
        [JsonProperty("FName")]
        public string Name { get; set; }
        /// <summary>
        /// 规格型号
        /// </summary>
        [JsonProperty("FSpecification")]
        public string Specification { get; set; }
    }
}
