using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public abstract class ComponentExcel: Component, IComponentExcel
    {
        public abstract string Name { get; }

        public abstract string Title { get; }

        public abstract string Describe { get; }

        public abstract ITaskManager GetTaskManager(IContainer container);


    }
}
