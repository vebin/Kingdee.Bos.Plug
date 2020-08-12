using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Dto
{
    public class GetInputDto : BaseApiDto
    {
        /// <summary>
        ///  创建者组织内码，字符串类型（非必录）
        /// </summary>
        public long CreateOrgId{get;set;}
        /// <summary>
        ///  单据编码，字符串类型（使用编码时必录）
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// 表单内码（使用内码时必录）
        /// </summary>
        public long Id { get; set; }
    }
}
