using Autofac;
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

        IExcelScheme GetScheme(IContainer container);

        void Register(object builder);
    }
}
