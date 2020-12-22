using MgSoft.K3Cloud.WebApi.Common.Dto.Ar;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Ar
{
    /// <summary>
    /// 收款单Api
    /// </summary>
    public class Ar_ReceiveBillApi : BaseApi, IAr_ReceiveBillApi
    {
        protected override string formId => "AR_RECEIVEBILL";
        public Ar_ReceiveBillApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Ar_ReceiveBillApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public bool Save(Ar_ReceiveBillSaveInputDto Ar_ReceiveBillSaveInputDto)
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = Ar_ReceiveBillSaveInputDto
            });
            return true;
        }


        //public bool Save<T>(T Ar_ReceiveBillSaveInputDto) where T : Ar_ReceiveBillSaveInputDto
        //{
        //    base.Save(new SaveInputDto
        //    {
        //        FormId = formId,
        //        Model = Ar_ReceiveBillSaveInputDto
        //    });
        //    return true;
        //}

    }
}
