using MgSoft.K3Cloud.WebApi.Common.Dto.Bd;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Bd
{
    public class Bd_MaterialApi : BaseApi
    {
        protected override string formId => "BD_MATERIAL";

        public Bd_MaterialApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Bd_MaterialApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }
        
        public List<SaveOutPutDto> Save(Bd_MaterialSaveInputDto bd_MaterialSaveInputDto)
        {
            return base.Save(new SaveInputDto()
            {
                Model = bd_MaterialSaveInputDto
            });
        }

        public List<SaveOutPutDto> Save<T>(T bd_MaterialSaveInputDto)
        {
            return base.Save(new SaveInputDto()
            {
                Model = bd_MaterialSaveInputDto
            });
        }
    }
}
