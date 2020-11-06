using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Property
{
    /// <summary>
    /// 根据名称检索
    /// </summary>
    public class FNameProperty
    {
        public FNameProperty()
        {
        }

        public FNameProperty(string FName)
        {
            this.FName = FName;
        }
        [JsonProperty("FName")]
        public string FName { get; set; }
    }
}
