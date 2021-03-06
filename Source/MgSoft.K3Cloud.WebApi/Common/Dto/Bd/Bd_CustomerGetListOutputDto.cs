﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    /// <summary>
    /// 客户列表查询Dto
    /// </summary>
    public class Bd_CustomerGetListOutputDto
    {
        /// <summary>
        /// 客户编码
        /// </summary>
        [JsonProperty("FNumber")]
        public string Number { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        [JsonProperty("FName")]
        public string Name { get; set; }
    }
}
