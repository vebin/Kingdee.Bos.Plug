using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Property
{
    /// <summary>
    /// 用户
    /// </summary>
    public class FUserIDProperty
    {
        [JsonProperty("FUserID")]
        public long FUserID { get; set; }
    }
}
