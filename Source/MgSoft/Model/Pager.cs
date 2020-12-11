using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.Model
{
    public class Pager : IPager
    {

        /// <summary>
        /// 每页最大行数
        /// </summary>
        public int PageSize { get; set; } = 100;

        /// <summary>
        /// 页码
        /// </summary>
        public int CurrentPageIndex { get; set; } = 0;

        /// <summary>
        /// 起始行
        /// </summary>
        public int StartRowIndex
        {
            get
            {
                return (CurrentPageIndex - 1) * PageSize;
            }
        }
        /// <summary>
        /// 结束行
        /// </summary>
        public int EndRowIndex
        {
            get
            {
                return StartRowIndex + PageSize;
            }
        }

    }
}
