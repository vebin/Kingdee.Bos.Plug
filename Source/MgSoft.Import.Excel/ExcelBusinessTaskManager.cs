using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public abstract class ExcelBusinessTaskManager : IExcelBusinessTaskManager
    {
        public abstract string Name { get; }

        public abstract string Title { get; }

        public abstract string Describe { get; }
    }
}
