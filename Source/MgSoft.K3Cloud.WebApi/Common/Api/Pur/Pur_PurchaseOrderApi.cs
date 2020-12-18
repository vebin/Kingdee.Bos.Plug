using MgSoft.K3Cloud.WebApi.Common.Dto.Pur;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Pur
{
    /// <summary>
    /// 采购订单Api
    /// </summary>
    public class Pur_PurchaseOrderApi : BaseApi
    {
        protected override string formId => "PUR_PurchaseOrder";
        public Pur_PurchaseOrderApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Pur_PurchaseOrderApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public bool Save(Pur_PurchaseOrderSaveInputDto Pur_PurchaseOrderSaveInputDto)
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = Pur_PurchaseOrderSaveInputDto
            });
            return true;
        }


        //public bool Save<T>(T Pur_PurchaseOrderSaveInputDto) where T : Pur_PurchaseOrderSaveInputDto
        //{
        //    base.Save(new SaveInputDto
        //    {
        //        FormId = formId,
        //        Model = Pur_PurchaseOrderSaveInputDto
        //    });
        //    return true;
        //}


    }
}
