using MgSoft.K3Cloud.WebApi.Common.Dto.Sal;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Sal
{
    public interface ISal_OutStockApi : IWebApi
    {
        bool Save(Sal_OutStockSaveInputDto OutStockSaveInputDTO);
    }
}