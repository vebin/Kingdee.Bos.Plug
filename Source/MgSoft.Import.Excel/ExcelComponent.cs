using Autofac;
using MgSoft.Import.Excel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public abstract class ExcelComponent : Component, IExcelComponent
    {
        public abstract string Name { get; }

        public abstract string Title { get; }

        public abstract string Describe { get; }

        public abstract List<ExcelTaskType> GetAllExcelTaskType(IContainer container);

        public abstract IExcelScheme GetScheme(IContainer container);
    }
}
