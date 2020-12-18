using MgSoft.K3Cloud.WebApi.Common.Dto.Bd;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Bd
{
    /// <summary>
    /// 供应商Api
    /// </summary>
    public class Bd_SupplierApi : BaseApi
    {
        protected override string formId => "BD_Supplier";
        public Bd_SupplierApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Bd_SupplierApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public List<SaveOutPutDto> Save(Bd_SupplierSaveInputDto bd_SupplierSaveInputDto)
        {
            return base.Save(new SaveInputDto()
            {
                FormId = formId,
                Model = bd_SupplierSaveInputDto
            });
        }

        //public List<SaveOutPutDto> Save<T>(T bd_SupplierSaveInputDto) where T : Bd_SupplierSaveInputDto
        //{
        //    return base.Save(new SaveInputDto()
        //    {
        //        FormId = formId,
        //        Model = bd_SupplierSaveInputDto
        //    });
        //}

    }
}
