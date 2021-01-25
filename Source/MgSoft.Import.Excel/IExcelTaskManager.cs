using MgSoft.Import.Excel.Model;

namespace MgSoft.Import.Excel
{
    public interface IExcelTaskManager
    {
        string Name { get; }

        string Title { get; }

        string Describe { get; }

        void Do(AggregateExcelMessage aggregateExcelMessage);
        void SetExcelFilePath(string excelFilePath);
        void InitAndCheck(AggregateExcelMessage aggregateExcelMessage);
    }
}