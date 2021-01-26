using MgSoft.Excel;
using MgSoft.Import.Excel.Model;

namespace MgSoft.Import.Excel
{
    public interface IExcelTask<TDto>:IMgTask
    {
        void Do(TDto dto, AggregateExcelMessage aggregateExcelMessage, TaskManagerInfoArg taskManagerInfoArg);
    }
}