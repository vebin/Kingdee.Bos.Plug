using MgSoft.K3Cloud.WebApi.Common.Dto.Gl;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Gl
{
    /// <summary>
    /// 凭证Api
    /// </summary>
    public class Gl_VoucherApi : BaseApi
    {
        protected override string formId => "Gl_Voucher";
        public Gl_VoucherApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Gl_VoucherApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public bool Save(Gl_VoucherSaveInputDto Gl_VoucherSaveInputDto)
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = Gl_VoucherSaveInputDto
            });
            return true;
        }


        //public bool Save<T>(T Gl_VoucherSaveInputDto) where T : Gl_VoucherSaveInputDto
        //{
        //    base.Save(new SaveInputDto
        //    {
        //        FormId = formId,
        //        Model = Gl_VoucherSaveInputDto
        //    });
        //    return true;
        //}
    }
}
