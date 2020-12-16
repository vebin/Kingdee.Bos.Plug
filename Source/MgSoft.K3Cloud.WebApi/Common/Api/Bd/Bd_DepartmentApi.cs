using MgSoft.K3Cloud.WebApi.Common.Dto.Bd;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Bd
{
    /// <summary>
    /// 部门Api
    /// </summary>
    public class Bd_DepartmentApi : BaseApi
    {
        protected override string formId => "BD_Department";
        public Bd_DepartmentApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Bd_DepartmentApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public List<SaveOutPutDto> Save(Bd_DepartmentSaveInputDto bd_DepartmentSaveInputDto)
        {
            return base.Save(new SaveInputDto()
            {
                FormId = formId,
                Model = bd_DepartmentSaveInputDto
            });
        }

        //public List<SaveOutPutDto> Save<T>(T bd_DepartmentSaveInputDto) where T : Bd_DepartmentSaveInputDto
        //{
        //    return base.Save(new SaveInputDto()
        //    {
        //        FormId = formId,
        //        Model = bd_DepartmentSaveInputDto
        //    });
        //}




    }
}
