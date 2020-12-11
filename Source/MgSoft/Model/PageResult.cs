using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.Model
{
    public class PageResult<T> : Pager, IPageResult<T>
    {
        /// <summary>
        /// 数据
        /// </summary>
        public List<T> Data { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        public int RowCount { get; set; } = 0;


        /// <summary>
        /// 页数
        /// </summary>
        public int PageCount
        {
            get
            {
                return RowCount / PageSize;
            }

        }
    }
}
