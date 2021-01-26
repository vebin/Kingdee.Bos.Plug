using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel.Model
{
    interface IProcessInfo
    {
        double GetPercent();
        int GetSyncRowNumber();
        int GetTotalRowCount();
        void SetProcessRow(int row=1);
        void SetProcessTotalRow(int totleRow);
    }
}
