using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    public class Bd_DepartmentQueryListOutputDto
    {
        [JsonProperty(propertyName: "FDeptId")]
        public virtual long Id { get; set; }

        [JsonProperty(propertyName: "FNumber")]
        public virtual string Number { get; set; }

        [JsonProperty(propertyName: "FName")]
        public virtual string Name { get; set; }
    }
}
