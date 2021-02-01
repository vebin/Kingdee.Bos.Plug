using MgSoft.Excel;
using MgSoft.Excel.Model.Excel;
using MgSoft.Import.Excel.Model;

namespace MgSoft.Import.Excel
{
    public interface IExcelTask<TDto> : IMgTask
    {
        void CheckMgRow(MgRow mgRow, TaskManagerInfoArg taskManagerInfoArg);
        void Do(TDto dto, TaskManagerInfoArg taskManagerInfoArg);
    }
}