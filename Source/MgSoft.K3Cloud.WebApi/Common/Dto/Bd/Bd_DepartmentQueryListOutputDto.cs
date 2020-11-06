using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    public class Bd_DepartmentQueryListOutputDto
    {
        [JsonProperty(propertyName: "FDeptId")]
        public long Id { get; set; }

        [JsonProperty(propertyName: "FNumber")]
        public string Number { get; set; }

        [JsonProperty(propertyName: "FName")]
        public string Name { get; set; }
    }
}
