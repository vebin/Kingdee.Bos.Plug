using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    /// <summary>
    /// 供应商列表查询Dto
    /// </summary>
    public class Bd_SupplierGetListOutputDto
    {
        /// <summary>
        /// 供应商编码
        /// </summary>
        [JsonProperty("FNumber")]
        public string Number { get; set; }
        /// <summary>
        /// 供应商名称
        /// </summary>
        [JsonProperty("FName")]
        public string Name { get; set; }
    }
}
