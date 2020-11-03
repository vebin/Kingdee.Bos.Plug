﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    public class Bd_Material_FBarCodeEntity_CMK
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long FEntryID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCodeType_CMK { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FUnitId_CMK { get; set; }
    }
}
