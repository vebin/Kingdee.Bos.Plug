using MgSoft.K3Cloud.WebApi.Common.Dto.Sal_ReturnStock;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Sal_ReturnStock
{
    public interface ISal_ReturnStockApi : IWebApi
    {
        bool Save(Sal_ReturnStockSaveInputDto ReturnStockSaveInputDTO);
    }
}