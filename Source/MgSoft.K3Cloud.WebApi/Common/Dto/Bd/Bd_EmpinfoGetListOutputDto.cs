using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    /// <summary>
    /// 员工查询列表Dto
    /// </summary>
    public class Bd_EmpinfoGetListOutputDto
    {
        /// <summary>
        /// 员工编码
        /// </summary>
        [JsonProperty("FNumber")]
        public string Number { get; set; }
        /// <summary>
        /// 员工名称
        /// </summary>
        [JsonProperty("FName")]
        public string Name { get; set; }
    }
}
