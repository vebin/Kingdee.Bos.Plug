using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Model
{
    public class BaseData
    {
        public long Id { get; set; }

        public string Number { get; set; }

        public MultiLanguageText[] MultiLanguageText { get; set; }

        public List<KeyValuePair<string,string>> Name { get; set; }
    }
}
