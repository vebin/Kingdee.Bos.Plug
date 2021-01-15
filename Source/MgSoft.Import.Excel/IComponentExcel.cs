using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public interface IComponentExcel
    {
        string Describe { get; }
        string Name { get; }
        string Title { get; }

        ITaskManager GetTaskManager(IContainer container);

        void Register(object builder);
    }
}
