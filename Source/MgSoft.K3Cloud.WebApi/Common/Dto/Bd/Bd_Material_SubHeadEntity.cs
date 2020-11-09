using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    public class Bd_Material_SubHeadEntity
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FEntryId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBARCODE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FErpClsID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FFeatureItem { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCONFIGTYPE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCategoryID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FTaxType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FTaxRateId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBaseUnitId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsPurchase { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsInventory { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsSubContract { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsSale { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsProduce { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsAsset { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FGROSSWEIGHT { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FNETWEIGHT { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FWEIGHTUNITID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FLENGTH { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FWIDTH { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FHEIGHT { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FVOLUME { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FVOLUMEUNITID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSuite { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FCostPriceRate { get; set; }
    }
}
