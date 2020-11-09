using MgSoft.K3Cloud.WebApi.Common.Dto.Bd;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Bd
{
    /// <summary>
    /// 员工Api
    /// </summary>
    public class Bd_EmpinfoApi : BaseApi
    {
        protected override string formId => "BD_Empinfo";
        public Bd_EmpinfoApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Bd_EmpinfoApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public List<SaveOutPutDto> Save(Bd_EmpinfoSaveInputDto bd_EmpinfoSaveInputDto)
        {
            return base.Save(new SaveInputDto()
            {
                FormId = formId,
                Model = bd_EmpinfoSaveInputDto
            });
        }

        public List<SaveOutPutDto> Save<T>(T bd_EmpinfoSaveInputDto) where T : Bd_EmpinfoSaveInputDto
        {
            return base.Save(new SaveInputDto()
            {
                FormId = formId,
                Model = bd_EmpinfoSaveInputDto
            });
        }

    }
}
