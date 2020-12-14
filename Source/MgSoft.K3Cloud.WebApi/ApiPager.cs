using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.WebApi
{
    public class ApiPager
    {
        public int PageIndex { get; set; } = 0;

        /// <summary>
        /// 获取数据条数
        /// </summary>
        public int RowCount { get; set; } = 100;

        public int StartRow
        {
            get
            {
                return (this.PageIndex - 1) * this.RowCount;
            }
        }
    }
}
