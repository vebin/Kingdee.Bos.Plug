using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Dto
{
    public class SubmitInputDto : BaseApiDto
    {
        /// <summary>
        /// 创建者组织内码，字符串类型（非必录）
        /// </summary>

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long CreateOrgId { get; set; }

        /// <summary>
        /// 单据编码集合，数组类型，格式：[No1,No2,...]（使用编码时必录）
        /// </summary>

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] Numbers { get; set; }

        /// <summary>
        /// 单据内码集合，字符串类型，格式："Id1,Id2,..."（使用内码时必录）
        /// </summary>

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Ids { get; set; }

        /// <summary>
        /// 工作流发起员工岗位内码，整型（非必录） 注（员工身兼多岗时不传参默认取第一个岗位）
        /// </summary>

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long SelectedPostId { get; set; }

        /// <summary>
        /// 是否启用网控，布尔类型，默认false（非必录）
        /// </summary>

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkCtrl { get; set; }
    }
}
