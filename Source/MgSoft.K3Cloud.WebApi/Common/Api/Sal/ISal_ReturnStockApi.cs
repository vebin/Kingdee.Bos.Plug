using MgSoft.K3Cloud.WebApi.Common.Dto.Sal_ReturnStock;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Sal_ReturnStock
{
    /// <summary>
    /// 销售退货单
    /// </summary>
    public interface ISal_ReturnStockApi : IWebApi
    {
        bool Save(Sal_ReturnStockSaveInputDto ReturnStockSaveInputDTO);
    }
}