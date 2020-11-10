using MgSoft.K3Cloud.WebApi.Common.Dto.Ap;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Ap
{
    /// <summary>
    /// 付款退款单Api
    /// </summary>
    public class Ap_RefundBillApi : BaseApi
    {
        protected override string formId => "AP_REFUNDBILL";
        public Ap_RefundBillApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Ap_RefundBillApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public bool Save(Ap_RefundBillSaveInputDto Ap_RefundBillSaveInputDto)
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = Ap_RefundBillSaveInputDto
            });
            return true;
        }


        public bool Save<T>(T Ap_RefundBillSaveInputDto) where T : Ap_RefundBillSaveInputDto
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = Ap_RefundBillSaveInputDto
            });
            return true;
        }
    }
}
