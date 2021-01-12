using MgSoft.K3Cloud.WebApi.Common.Dto.Sal;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Sal
{
    /// <summary>
    /// 销售出库单
    /// </summary>
    public interface ISal_OutStockApi : IWebApi
    {
        bool Save(Sal_OutStockSaveInputDto OutStockSaveInputDTO);
    }
}