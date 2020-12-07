using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Pur
{
    /// <summary>
    /// (采购合同)合同条款
    /// </summary>
    public class Pur_Constract_ContractClause
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FClauseId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FClauseDesc { get; set; }
    }
}
