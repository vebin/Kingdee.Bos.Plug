using System.Collections.Generic;

namespace MgSoft
{
    public interface IPageResult<T> : IPager
    {
        List<T> Data { get; set; }

        int RowCount { get; set; }

        int PageCount { get; }
    }
}