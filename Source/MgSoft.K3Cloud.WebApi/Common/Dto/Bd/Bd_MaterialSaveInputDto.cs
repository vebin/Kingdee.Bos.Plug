using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    public class Bd_MaterialSaveInputDto
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FMATERIALID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCreateOrgId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FUseOrgId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FNumber { get; set; }

        /// <summary>
        /// 必填
        /// </summary>
        public string FName { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FSpecification { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FMnemonicCode { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FOldNumber { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FDescription { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FMaterialGroup { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FImgStorageType { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FIsSalseByNet { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Bd_Material_FSubHeadEntity FSubHeadEntity { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Bd_Material_SubHeadEntity SubHeadEntity { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Bd_Material_SubHeadEntity1 SubHeadEntity1 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Bd_Material_SubHeadEntity2 SubHeadEntity2 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Bd_Material_SubHeadEntity3 SubHeadEntity3 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Bd_Material_SubHeadEntity4 SubHeadEntity4 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Bd_Material_SubHeadEntity5 SubHeadEntity5 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Bd_Material_SubHeadEntity7 SubHeadEntity7 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Bd_Material_SubHeadEntity6 SubHeadEntity6 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        List<Bd_Material_FBarCodeEntity_CMK> FBarCodeEntity_CMK { get; set; }

        //List<Bd_Material_FSpecialAttributeEntity> FSpecialAttributeEntity { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        List<Bd_Material_FEntityAuxPty> FEntityAuxPty { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        List<Bd_Material_FEntityInvPty> FEntityInvPty { get; set; }
    }
}
