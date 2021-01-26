using MgSoft.Excel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MgSoft.Import.Excel
{
    public abstract class TemplateConfigService : ITemplateConfigService
    {
        public abstract TemplateConfig GetTemplateConfig();

        public TemplateCellConfig GetTemplateCellConfigByName(string name)
        {
            var config = GetTemplateConfig();
            var templateConfig = config.TemplateCellConfigs.Where(p => p.Name == name).SingleOrDefault();
            if (templateConfig == null)
            {
                throw new MgException($"找不到列名{name}");
            }
            return templateConfig;
        }
    }
}
