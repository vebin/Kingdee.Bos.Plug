﻿using MgSoft.Excel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Excel
{
    public interface ITemplateConfigService
    {
        TemplateCellConfig GetTemplateCellConfigByName(string name);
        TemplateConfig GetTemplateConfig();
    }
}
