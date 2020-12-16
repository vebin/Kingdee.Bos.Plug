using MgSoft.K3Cloud.WebApi.Common.Dto.Sal;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Sal
{
    /// <summary>
    /// 销售订单Api
    /// </summary>
    public class Sal_SaleOrderApi : BaseApi
    {
        protected override string formId => "Sal_SaleOrder";
        public Sal_SaleOrderApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Sal_SaleOrderApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public bool Save(Sal_SaleOrderSaveInputDto Sal_SaleOrderSaveInputDto)
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = Sal_SaleOrderSaveInputDto
            });
            return true;
        }


        //public bool Save<T>(T Sal_SaleOrderSaveInputDto) where T : Sal_SaleOrderSaveInputDto
        //{
        //    base.Save(new SaveInputDto
        //    {
        //        FormId = formId,
        //        Model = Sal_SaleOrderSaveInputDto
        //    });
        //    return true;
        //}


    }
}
