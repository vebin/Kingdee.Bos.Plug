﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Stk
{
    /// <summary>
    /// (其他入库单)序列号子单据体
    /// </summary>
    public class Stk_Miscellaneous_SerialSubEntity
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FDetailID { get; set; }
        public virtual string FSerialNo { get; set; }
        public virtual string FSerialNote { get; set; }
    }
}
