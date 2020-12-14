using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.DependenceInjection.Autofac
{
    public static class GlobalContainer
    {
        public static IContainer Container { get; private set; }

        public static void SetContrainer(IContainer container)
        {
            Container = container;
        }
    }
}
