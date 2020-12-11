namespace MgSoft
{
    public interface IPager
    {
        /// <summary>
        /// 每页最大行数
        /// </summary>
        int PageSize { get; set; } 

        /// <summary>
        /// 当前页
        /// </summary>
        int CurrentPageIndex { get; set; }

        /// <summary>
        /// 起始行
        /// </summary>
        int StartRowIndex { get; }
        /// <summary>
        /// 结束行
        /// </summary>
        int EndRowIndex { get; }
    }
}