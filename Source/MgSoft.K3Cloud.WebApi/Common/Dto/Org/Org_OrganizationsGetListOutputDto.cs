using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Org
{
    /// <summary>
    /// 组织机构查询列表Dto
    /// </summary>
    public class Org_OrganizationsGetListOutputDto
    {
        /// <summary>
        /// 组织机构编码
        /// </summary>
        [JsonProperty("FNumber")]
        public string Number { get; set; }
        /// <summary>
        /// 组织机构名称
        /// </summary>
        [JsonProperty("FName")]
        public string Name { get; set; }
    }
}
