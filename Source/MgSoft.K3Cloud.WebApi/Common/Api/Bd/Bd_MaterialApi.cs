using MgSoft.K3Cloud.WebApi.Common.Dto.BD;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Bd
{
    public class Bd_MaterialApi : BaseApi
    {
        private const string formId = "BD_MATERIAL";

        public Bd_MaterialApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Bd_MaterialApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }
        
        public bool Save(Bd_MaterialSaveInputDto bd_MaterialSaveInputDto)
        {
            base.Save(new SaveInputDto()
            {
                FormId = formId,
                Model = bd_MaterialSaveInputDto
            });

            return true;
        }

        public bool Save<T>(T bd_MaterialSaveInputDto)
        {
            base.Save(new SaveInputDto()
            {
                FormId = formId,
                Model = bd_MaterialSaveInputDto
            });
            return true;
        }


    }
}
