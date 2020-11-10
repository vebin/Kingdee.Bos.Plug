using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    /// <summary>
    /// (供应商)基本信息
    /// </summary>
    public class Bd_Supplier_BaseInfo
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCountry { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FProvincial { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FAddress { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FZip { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FLanguage { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FWebSite { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FTrade { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime FFoundDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FLegalPerson { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal FRegisterFund { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FRegisterCode { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSOCIALCRECODE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FTendPermit { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FRegisterAddress { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FDeptId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FStaffId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSupplierClassify { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSupplyClassify { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSupplierGrade { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCompanyClassify { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCompanyNature { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCompanyScale { get; set; }
    }
}
