using MgSoft.K3Cloud.WebApi.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Model
{
    /// <summary>
    /// 基础资料
    /// </summary>
    public class BaseData : BaseData<MultiLanguageText>
    {

    }

    public class BaseData<T> where T : MultiLanguageText
    {
        public object Id { get; set; }

        public string Number { get; set; }

        public T[] MultiLanguageText { get; set; }

        public List<KeyValuePair<string, string>> Name { get; set; }
    }
}
