using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Bd
{
    /// <summary>
    /// 仓库API
    /// </summary>
    public class Bd_StockApi : BaseApi, IBd_StockApi
    {
        protected override string formId => "BD_STOCK";
        public Bd_StockApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Bd_StockApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

    }
}
