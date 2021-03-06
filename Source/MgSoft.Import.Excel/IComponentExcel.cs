﻿using Autofac;
using MgSoft.Component;
using MgSoft.Import.Excel.Model;
using MgSoft.Import.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public interface IExcelComponent: IConfigUi,IMgComponent
    {
        string Describe { get; }
        string Name { get; }
        string Title { get; }

        List<ExcelTaskTypeInfo> GetAllExcelTaskType(IContainer container);
        IExcelScheme GetScheme(IContainer container);

        void Register(object builder);
    }
}