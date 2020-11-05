using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MgSoft.K3Cloud.WebApi.Common.Dto.Stk;
using MgSoft.K3Cloud.WebApi.Dto;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Stk
{
    /// <summary>
    /// 采购入库单
    /// </summary>
    public class Stk_InStockApi : BaseApi
    {
        private const string formId = "STK_InStock";

        public Stk_InStockApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Stk_InStockApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public bool Save(Stk_InStockSaveInputDto inStockSaveInputDto)
        {
            base.Save(new SaveInputDto()
            {
                FormId = formId,
                Model = inStockSaveInputDto
            });

            return true;
        }

        public bool Save<T>(T inStockSaveInputDto) where T : Stk_InStockSaveInputDto
        {
            base.Save(new SaveInputDto()
            {
                FormId = formId,
                Model = inStockSaveInputDto
            });

            return true;
        }
    }
}
