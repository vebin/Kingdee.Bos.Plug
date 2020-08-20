using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Model
{
    public class MultiLanguageText
    {
        public int LocaleId { get; set; }
        public string Name { get; set; }

        public string FDataValue { get; set; }

        public string Description { get; set; }


        /// <summary>
        /// 规格型号
        /// </summary>
        public string Specification { get; set; }

        /// <summary>
        /// 品材/材质
        /// </summary>
        [JsonProperty(PropertyName = "F_jghy_MulLangText")]
        public string Quality { get; set; }
    }
}