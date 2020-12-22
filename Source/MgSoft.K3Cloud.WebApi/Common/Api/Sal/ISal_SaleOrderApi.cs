using MgSoft.K3Cloud.WebApi.Common.Dto.Sal;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Sal
{
    public interface ISal_SaleOrderApi : IWebApi
    {
        bool Save(Sal_SaleOrderSaveInputDto Sal_SaleOrderSaveInputDto);
    }
}