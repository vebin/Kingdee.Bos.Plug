using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    public class Bd_CustomerSaveInputDto
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FCustId { get; set; }

        /// <summary>
        /// 客户名称(必填)
        /// </summary>
        public virtual string FName { get; set; }

        /// <summary>
        /// 客户编码
        /// </summary>
        public virtual string FNumber { get; set; }
        /// <summary>
        /// 创建组织(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCreateOrgId { get; set; }

        /// <summary>
        /// 结算币别(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FTradingcurrId { get; set; }
    }
}
