using Autofac;
using MgSoft.Import.Excel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public interface IExcelComponent
    {
        string Describe { get; }
        string Name { get; }
        string Title { get; }

        List<ExcelTaskType> GetAllExcelTaskType(IContainer container);
        IExcelScheme GetScheme(IContainer container);

        void Register(object builder);
    }
}
