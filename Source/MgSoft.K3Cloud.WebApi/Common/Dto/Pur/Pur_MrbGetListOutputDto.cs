using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Pur
{
    /// <summary>
    /// 采购退料单查询列表Dto
    /// </summary>
    public class Pur_MrbGetListOutputDto : BaseApiOutputDto
    {
        /// <summary>
        /// 分录内码
        /// </summary>
        [JsonProperty("FPURMRBENTRY_FEntryId")]
        public virtual long FEntryId { get; set; }
        /// <summary>
        /// 实退数量
        /// </summary>
        [JsonProperty("FRMREALQTY")]
        public decimal Qty { get; set; }
        /// <summary>
        /// 单据状态
        /// </summary>
        [JsonProperty("FDocumentStatus")]
        public string FDocumentStatus { get; set; }
    }
}
