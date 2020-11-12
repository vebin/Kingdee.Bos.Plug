using MgSoft.K3Cloud.WebApi.Common.Dto.Ar;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Ar
{
    /// <summary>
    /// 应收单Api
    /// </summary>
    public class Ar_ReceivableApi : BaseApi
    {
        protected override string formId => "AR_receivable";
        public Ar_ReceivableApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Ar_ReceivableApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public bool Save(Ar_ReceivableSaveInputDto Ar_ReceivableSaveInputDto)
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = Ar_ReceivableSaveInputDto
            });
            return true;
        }


        public bool Save<T>(T Ar_ReceivableSaveInputDto) where T : Ar_ReceivableSaveInputDto
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = Ar_ReceivableSaveInputDto
            });
            return true;
        }

    }
}
