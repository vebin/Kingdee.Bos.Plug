using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MgSoft.Import.Excel
{
    public abstract class ExcelController : Controller, IExcelController
    {
        public List<IExcelComponent> Components { get; protected set; }

        public IExcelComponent GetComponent(string componentName)
        {
            var result=Components.Where(p => p.Name == componentName).SingleOrDefault();
            if(result==null)
            {
                throw new MgException("找不到组件");
            }
            return result;
        }
    }
}
