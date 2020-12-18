using MgSoft.K3Cloud.WebApi.Common.Dto.Ap;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Ap
{
    /// <summary>
    /// 其他应付单Api
    /// </summary>
    public class Ap_OtherPayableApi : BaseApi
    {
        protected override string formId => "Ap_OtherPayable";
        public Ap_OtherPayableApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Ap_OtherPayableApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public bool Save(Ap_OtherPayableSaveInputDto Ap_OtherPayableSaveInputDto)
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = Ap_OtherPayableSaveInputDto
            });
            return true;
        }


        //public bool Save<T>(T Ap_OtherPayableSaveInputDto) where T : Ap_OtherPayableSaveInputDto
        //{
        //    base.Save(new SaveInputDto
        //    {
        //        FormId = formId,
        //        Model = Ap_OtherPayableSaveInputDto
        //    });
        //    return true;
        //}
        

    }
}
