using MgSoft.Excel;
using MgSoft.Import.Excel.Model;

namespace MgSoft.Import.Excel
{
    public interface IExcelTaskManager
    {
        string Name { get; }

        string Title { get; }

        string Describe { get; }

        /// <summary>
        /// 读取到的Excel
        /// </summary>
        MgExcel MgExcel { get; }

        void Do(TaskManagerInfoArg taskManagerInfoArg);

        void InitAndCheck(TaskManagerInfoArg taskManagerInfoArg);
    }
}