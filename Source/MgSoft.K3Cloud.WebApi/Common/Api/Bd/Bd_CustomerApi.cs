using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Bd
{
    /// <summary>
    /// 客户
    /// </summary>
    public class Bd_CustomerApi : BaseApi, IBd_CustomerApi
    {
        protected override string formId => "BD_Customer";
        public Bd_CustomerApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Bd_CustomerApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        //TODO:保存接口没写

    }
}
