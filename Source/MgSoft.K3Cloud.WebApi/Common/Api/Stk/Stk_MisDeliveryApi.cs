using MgSoft.K3Cloud.WebApi.Common.Dto.Stk;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Stk
{
    /// <summary>
    /// 其他出库单
    /// </summary>
    public class Stk_MisDeliveryApi : BaseApi, IStk_MisDeliveryApi
    {
        protected override string formId => "Stk_MisDelivery";
        public Stk_MisDeliveryApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Stk_MisDeliveryApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public List<SaveOutPutDto> Save(Stk_MisDeliverySaveInputDto stk_MisDeliverySaveInputDto)
        {
            return base.Save(new SaveInputDto()
            {
                Model = stk_MisDeliverySaveInputDto
            });
        }
    }
}
