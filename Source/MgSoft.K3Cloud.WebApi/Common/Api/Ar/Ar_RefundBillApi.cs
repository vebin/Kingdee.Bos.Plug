using MgSoft.K3Cloud.WebApi.Common.Dto.Ar;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Ar
{
    /// <summary>
    /// 收款退款单Api
    /// </summary>
    public class Ar_RefundBillApi : BaseApi
    {
        protected override string formId => "AR_REFUNDBILL";
        public Ar_RefundBillApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Ar_RefundBillApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public bool Save(Ar_RefundSaveInputDtp Ar_RefundSaveInputDtp)
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = Ar_RefundSaveInputDtp
            });
            return true;
        }


        //public bool Save<T>(T Ar_RefundSaveInputDtp) where T : Ar_RefundSaveInputDtp
        //{
        //    base.Save(new SaveInputDto
        //    {
        //        FormId = formId,
        //        Model = Ar_RefundSaveInputDtp
        //    });
        //    return true;
        //}
    }
}
