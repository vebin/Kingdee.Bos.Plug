using MgSoft.K3Cloud.WebApi.Common.Dto.Sp;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Sp
{
    public class Sp_InstockApi : BaseApi
    {
        protected override string formId => "Sp_Instock";
        public Sp_InstockApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Sp_InstockApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public bool Save(Sp_InstockSaveInputDto sp_InstockSaveInputDto)
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = sp_InstockSaveInputDto
            });
            return true;
        }


        //public bool Save<T>(T sp_InstockSaveInputDto) where T : Sp_InstockSaveInputDto
        //{
        //    base.Save(new SaveInputDto
        //    {
        //        FormId = formId,
        //        Model = sp_InstockSaveInputDto
        //    });
        //    return true;
        //}

    }
}
