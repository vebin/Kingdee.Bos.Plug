using MgSoft.K3Cloud.WebApi.Common.Dto.Pur;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Pur
{
    public class Pur_ConstractApi : BaseApi
    {
        protected override string formId => "PUR_Contract";
        public Pur_ConstractApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Pur_ConstractApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public bool Save(Pur_ConstractSaveInputDto Pur_ConstractSaveInputDto)
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = Pur_ConstractSaveInputDto
            });
            return true;
        }


        //public bool Save<T>(T Pur_ConstractSaveInputDto) where T : Pur_ConstractSaveInputDto
        //{
        //    base.Save(new SaveInputDto
        //    {
        //        FormId = formId,
        //        Model = Pur_ConstractSaveInputDto
        //    });
        //    return true;
        //}
    }
}
