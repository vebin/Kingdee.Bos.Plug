using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Org
{
    /// <summary>
    /// 组织机构Api
    /// </summary>
    public class Org_OrganizationsApi : BaseApi, IOrg_OrganizationsApi
    {
        protected override string formId => "ORG_OrganizationsApi";

        public Org_OrganizationsApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Org_OrganizationsApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        
    }
}
