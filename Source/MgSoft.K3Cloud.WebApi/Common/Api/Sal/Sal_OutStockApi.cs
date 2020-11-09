using MgSoft.K3Cloud.WebApi.Common.Dto.Sal;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;
//using static MgSoft.K3Cloud.WebApi.Common.Dto.Sal.Sal_OutStockSaveInputDto<Type_Sal_SubHeadEntity, Type_Sal_OutStock_FEntity, Type_Sal_OutStock_FOutStockTrace>;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Sal
{
    /// <summary>
    /// 销售出库单Api
    /// </summary>
    public class Sal_OutStockApi : BaseApi
    {
        protected override string formId => "SAL_OUTSTOCK";
        public Sal_OutStockApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Sal_OutStockApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }


        public bool Save(Sal_OutStockSaveInputDto OutStockSaveInputDTO)
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = OutStockSaveInputDTO
            });
            return true;
        }


        public bool Save<T>(T OutStockSaveInputDTO) where T : Sal_OutStockSaveInputDto
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = OutStockSaveInputDTO
            });
            return true;
        }        
    }
}
