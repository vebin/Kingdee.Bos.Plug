using MgSoft.Excel;

namespace MgSoft.Import.Excel.Model
{
    public interface ITaskManagerInfoArg
    {
        AggregateExcelMessage AggregateExcelMessage { get; }
        FileExcelTaskTypeInfo FileExcelTaskTypeInfo { get; }
        MgExcel MgExcel { get; }

        void SetMgExcel(MgExcel mgExcel);
    }
}