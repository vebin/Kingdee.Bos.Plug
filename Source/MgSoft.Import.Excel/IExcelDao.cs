using MgSoft.Excel;

namespace MgSoft.Import.Excel
{
    public interface IExcelDao
    {
        MgExcel GetExcel(string excelFilePath);
    }
}