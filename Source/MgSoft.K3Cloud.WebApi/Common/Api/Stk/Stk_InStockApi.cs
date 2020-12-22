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
    public class Stk_InStockApi : BaseApi, IStk_InStockApi
    {
        protected override string formId => "STK_InStock";

        public Stk_InStockApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Stk_InStockApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public List<SaveOutPutDto> Save(Stk_InStockSaveInputDto inStockSaveInputDto)
        {
            return base.Save(new SaveInputDto()
            {
                Model = inStockSaveInputDto
            });
        }

        //public List<SaveOutPutDto> Save<T>(T inStockSaveInputDto) where T : Stk_InStockSaveInputDto
        //{
        //    return base.Save(new SaveInputDto()
        //    {
        //        Model = inStockSaveInputDto
        //    });
        //}

        //public override List<SaveOutPutDto> Save(SaveInputDto saveInputDto)
        //{
        //    return base.Save(saveInputDto);
        //}

        //public List<SaveOutPutDto> Save<T,Type_FInStockFin, Type_FInStockEntry>(T inStockSaveInputDto) where T : Stk_InStockSaveInputDto<Type_FInStockFin, Type_FInStockEntry>
        //    where Type_FInStockFin : Stk_InStock_FInStockFin
        //    where Type_FInStockEntry: Stk_InStock_FInStockEntry
        //{
        //    return base.Save(new SaveInputDto()
        //    {
        //        Model = inStockSaveInputDto
        //    });
        //}
    }
}
