using MgSoft.K3Cloud.WebApi.Common.Dto.Ap;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Ap
{
    /// <summary>
    /// 应付单Api
    /// </summary>
    public class Ap_PayableApi : BaseApi
    {
        protected override string formId => "AP_Payable";
        public Ap_PayableApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Ap_PayableApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public bool Save(Ap_PayableSaveInputDto Ap_PayableSaveInputDto)
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = Ap_PayableSaveInputDto
            });
            return true;
        }


        public bool Save<T>(T Ap_PayableSaveInputDto) where T : Ap_PayableSaveInputDto
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = Ap_PayableSaveInputDto
            });
            return true;
        }
    }
}
