using MgSoft.K3Cloud.WebApi.Common.Dto.Ap;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Ap
{
    /// <summary>
    /// 付款单Api
    /// </summary>
    public class Ap_PayBillApi : BaseApi, IAp_PayBillApi
    {
        protected override string formId => "AP_PAYBILL";
        public Ap_PayBillApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Ap_PayBillApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public bool Save(Ap_PayBillSaveInputDto Ap_PayBillSaveInputDto)
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = Ap_PayBillSaveInputDto
            });
            return true;
        }


        //public bool Save<T>(T Ap_PayBillSaveInputDto) where T : Ap_PayBillSaveInputDto
        //{
        //    base.Save(new SaveInputDto
        //    {
        //        FormId = formId,
        //        Model = Ap_PayBillSaveInputDto
        //    });
        //    return true;
        //}

    }
}
