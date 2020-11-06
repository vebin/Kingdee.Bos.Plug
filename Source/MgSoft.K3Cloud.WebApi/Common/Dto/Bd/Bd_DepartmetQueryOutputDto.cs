using MgSoft.K3Cloud.WebApi.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    public class Bd_DepartmetQueryOutputDto
    {
        [JsonProperty(PropertyName = "MultiLanguageText")]
        public MultiLanguageText[] MultiLanguageText { get; set; }

        [JsonProperty(PropertyName = "Id")]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "Number")]
        public string Number { get; set; }
        [JsonIgnore]
        public string Name
        {
            get
            {
                return MultiLanguageText[0].Name;
            }
        }

    }
}
