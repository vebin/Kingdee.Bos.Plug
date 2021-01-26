using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import
{
    public abstract class ImportComponent : Component, IImportComponent
    {
        public virtual string Name => this.GetType().FullName;

        public abstract string Title { get; }

        public abstract string Describe { get; }

        public abstract string TargetConfigName { get; }

    }
}
