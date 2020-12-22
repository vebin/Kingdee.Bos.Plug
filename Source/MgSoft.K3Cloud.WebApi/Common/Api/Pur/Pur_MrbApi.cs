using MgSoft.K3Cloud.WebApi.Common.Dto.Pur;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Pur
{
    /// <summary>
    /// 采购退料单Api
    /// </summary>
    public class Pur_MrbApi : BaseApi, IPur_MrbApi
    {
        protected override string formId => "PUR_MRB";
        public Pur_MrbApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Pur_MrbApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public bool Save(Pur_MrbSaveInputDto Pur_MrbSaveInputDto)
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = Pur_MrbSaveInputDto
            });
            return true;
        }


        //public bool Save<T>(T Pur_MrbSaveInputDto) where T : Pur_MrbSaveInputDto
        //{
        //    base.Save(new SaveInputDto
        //    {
        //        FormId = formId,
        //        Model = Pur_MrbSaveInputDto
        //    });
        //    return true;
        //}
    }
}
