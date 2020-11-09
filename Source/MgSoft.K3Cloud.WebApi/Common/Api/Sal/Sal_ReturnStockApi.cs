using MgSoft.K3Cloud.WebApi.Common.Dto.Sal_ReturnStock;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Sal_ReturnStock
{
    /// <summary>
    /// 销售退库单Api
    /// </summary>
    public class Sal_ReturnStockApi : BaseApi
    {
        protected override string formId => "SAL_RETURNSTOCK";
        public Sal_ReturnStockApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Sal_ReturnStockApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }


        public bool Save(Sal_ReturnStockSaveInputDto ReturnStockSaveInputDTO)
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = ReturnStockSaveInputDTO
            });
            return true;
        }


        public bool Save<T>(T ReturnStockSaveInputDTO) where T : Sal_ReturnStockSaveInputDto
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = ReturnStockSaveInputDTO
            });
            return true;
        }

    }
}
