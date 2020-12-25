using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Dto
{
    /// <summary>
    /// 查询列表输出Dto(只适用于单据)
    /// </summary>
    public class GetListOutputDto
    {
        [JsonProperty("FId")]
        public virtual long Id { get; set; }
        [JsonProperty("FBillNo")]
        public virtual string BillNo { get; set; }
    }
}
