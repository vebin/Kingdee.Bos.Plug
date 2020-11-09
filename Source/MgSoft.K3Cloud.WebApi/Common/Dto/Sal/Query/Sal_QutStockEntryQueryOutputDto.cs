using MgSoft.K3Cloud.WebApi.Common.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal.Query
{
    public class Sal_QutStockEntryQueryOutputDto
    {
        /// <summary>
        /// 物料
        /// </summary>
        [JsonProperty(propertyName: ("MaterialID"))]
        public virtual BaseData Material { get; set; }
    }
}
