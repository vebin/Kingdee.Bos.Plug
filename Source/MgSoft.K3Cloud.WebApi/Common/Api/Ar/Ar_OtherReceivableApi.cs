using MgSoft.K3Cloud.WebApi.Common.Dto.Ar;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Ar
{
    /// <summary>
    /// 其他应收单Api
    /// </summary>
    public class Ar_OtherReceivableApi : BaseApi
    {
        protected override string formId => "AR_OtherRecAble";
        public Ar_OtherReceivableApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Ar_OtherReceivableApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public bool Save(Ar_OtherReceivableSaveInputDto Ar_OtherReceivableSaveInputDto)
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = Ar_OtherReceivableSaveInputDto
            });
            return true;
        }


        public bool Save<T>(T Ar_OtherReceivableSaveInputDto) where T : Ar_OtherReceivableSaveInputDto
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = Ar_OtherReceivableSaveInputDto
            });
            return true;
        }

    }
}
