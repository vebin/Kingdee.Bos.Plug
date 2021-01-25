using MgSoft.Excel;
using MgSoft.Import.Excel.Model;

namespace MgSoft.Import.Excel
{
    public interface IExcelTask<TDto>:IMgTask
    {
        void Do(TDto dto, MgExcel mgExcel,AggregateExcelMessage aggregateExcelMessage);
    }
}