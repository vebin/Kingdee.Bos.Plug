using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Dto
{
    public class SaveInputDto:BaseApiDto
    {
        /// <summary>
        /// 需要更新的字段，数组类型，格式：[key1, key2,...] （非必录）注（更新单据体字段得加上单据体key）
        /// </summary>

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] NeedUpDateFields { get; set; }
        /// <summary>
        /// 需返回结果的字段集合，数组类型，格式：[key, entitykey.key,...]（非必录） 注（返回单据体字段格式：entitykey.key）
        /// </summary>

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] NeedReturnFields { get; set; }

        /// <summary>
        /// 是否删除已存在的分录，布尔类型，默认true（非必录）
        /// </summary>

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool IsDeleteEntry { get; set; }

        /// <summary>
        /// 表单所在的子系统内码，字符串类型（非必录）
        /// </summary>

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string SubSystemId { get; set; }

        /// <summary>
        /// 是否验证所有的基础资料有效性，布尔类，默认false（非必录）
        /// </summary>

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool IsVerifyBaseDataField { get; set; }

        /// <summary>
        /// ：是否批量填充分录，默认true（非必录）
        /// </summary>

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string IsEntryBatchFill { get; set; }

        /// <summary>
        /// ：是否验证标志，布尔类型，默认true（非必录）
        /// </summary>

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ValidateFlag { get; set; }

        /// <summary>
        /// 是否用编码搜索基础资料，布尔类型，默认true（非必录）
        /// </summary>

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool NumberSearch { get; set; }

        /// <summary>
        /// 交互标志集合，字符串类型，分号分隔，格式："flag1;flag2;..."（非必录） 例如（允许负库存标识：STK_InvCheckResult）
        /// </summary>

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string InterationFlags { get; set; }

        /// <summary>
        /// ：表单数据包，JSON类型（必录）
        /// </summary>

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object Model { get; set; }
    }
}
