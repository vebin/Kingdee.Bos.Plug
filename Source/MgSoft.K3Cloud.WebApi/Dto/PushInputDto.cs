using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Dto
{
    /// <summary>
    /// 下推通用Dto
    /// </summary>
    public class PushInputDto : BaseApiDto
    {
        /// <summary>
        /// 单据内码集合，字符串类型，格式："Id1,Id2,..."（使用内码时必录）
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Ids { get; set; }
        /// <summary>
        /// 单据编码集合，数组类型，格式：[No1,No2,...]（使用编码时必录）
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] Numbers { get; set; }
        /// <summary>
        /// 分录内码集合，逗号分隔（分录下推时必录） 注（按分录下推时，单据内码和编码不需要填,否则按整单下推）
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string EntryIds { get; set; }
        /// <summary>
        /// 转换规则内码，字符串类型（未启用默认转换规则时，则必录）
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }
        /// <summary>
        /// 目标单据类型内码，字符串类型（非必录）
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string TargetBillTypeId { get; set; }
        /// <summary>
        /// 目标组织内码，整型（非必录）
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? TargetOrgId { get; set; }
        /// <summary>
        /// 目标单据FormId，字符串类型，（启用默认转换规则时，则必录）
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string TargetFormId { get; set; }
        /// <summary>
        /// 是否启用默认转换规则，布尔类型，默认false（非必录）
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool IsEnableDefaultRule { get; set; }
        /// <summary>
        /// 保存失败时是否暂存，布尔类型，默认false（非必录）  注（暂存的单据是没有编码的）
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool IsDraftWhenSaveFail { get; set; }
        /// <summary>
        /// 自定义参数，字典类型，格式："{key1:value1,key2:value2,...}"（非必录）  注（传到转换插件的操作选项中，平台不会解析里面的值）
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> CustomParams { get; set; }
    }
}
