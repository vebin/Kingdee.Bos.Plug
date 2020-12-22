using MgSoft.K3Cloud.WebApi.Common.Dto.Stk;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Stk
{
    /// <summary>
    /// 其他入库单
    /// </summary>
    public class Stk_MiscellaneousApi : BaseApi, IStk_MiscellaneousApi
    {
        protected override string formId => "Stk_Miscellaneous";
        public Stk_MiscellaneousApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Stk_MiscellaneousApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public List<SaveOutPutDto> Save(Stk_MiscellaneousSaveInputDto stk_MiscellaneousSaveInputDto)
        {
            return base.Save(new SaveInputDto()
            {
                Model = stk_MiscellaneousSaveInputDto
            });
        }

    }
}
