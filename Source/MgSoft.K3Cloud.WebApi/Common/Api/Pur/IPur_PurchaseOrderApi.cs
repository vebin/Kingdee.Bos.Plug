using MgSoft.K3Cloud.WebApi.Common.Dto.Pur;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Pur
{
    public interface IPur_PurchaseOrderApi : IWebApi
    {
        bool Save(Pur_PurchaseOrderSaveInputDto Pur_PurchaseOrderSaveInputDto);
    }
}