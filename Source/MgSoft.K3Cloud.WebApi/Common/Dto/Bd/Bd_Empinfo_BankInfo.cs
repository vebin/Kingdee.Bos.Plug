using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    /// <summary>
    /// (员工)财务信息
    /// </summary>
    public class Bd_Empinfo_BankInfo
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FBankId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBankCountry { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBankCode { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBankTypeRec { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBankHolder { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FTextBankDetail { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBankDetail { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOpenBankName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOpenAddressRec { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCNAPS { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBankCurrencyId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool FBankIsDefault { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBankDesc { get; set; }
    }
}
