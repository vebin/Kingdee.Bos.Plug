using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Dto
{
    public class AuditInputDto : BaseApiDto
    {
        /// <summary>
        /// 创建者组织内码，字符串类型（非必录）
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateOrgId { get; set; }
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
        /// 交互标志集合，字符串类型，分号分隔，格式："flag1;flag2;..."（非必录） 例如（允许负库存标识：STK_InvCheckResult）
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string InterationFlags { get; set; }
        /// <summary>
        /// 是否启用网控，布尔类型，默认false（非必录）
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkCtrl { get; set; }
    }
}
