using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.WebApi.Dto
{
    public class QueryListInputDto : BaseApiDto
    {
        public override string FormId { get; set; }

        /// <summary>
        /// 需查询的字段key集合，字符串类型，格式："key1,key2,..."（必录） 注（查询单据体内码,需加单据体Key和下划线,如：FEntryKey_FEntryId）
        /// </summary>
        public string FieldKeys { get; set; }

        /// <summary>
        /// 过滤条件，字符串类型（非必录）
        /// </summary>
        public string FilterString { get; set; } = "";

        /// <summary>
        /// 排序字段，字符串类型（非必录）
        /// </summary>
        public string OrderString { get; set; } = "";

        /// <summary>
        /// 返回总行数，整型（非必录）
        /// </summary>
        public int TopRowCount { get; set; }

        /// <summary>
        /// ：开始行索引，整型（非必录）
        /// </summary>
        public int StartRow { get; set; }

        /// <summary>
        ///  最大行数，整型，不能超过2000（非必录）
        /// </summary>
        public int Limit { get; set; }
    }
}
