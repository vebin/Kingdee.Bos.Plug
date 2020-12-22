using MgSoft.K3Cloud.WebApi.Common.Dto.Ap;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Ap
{
    public interface IAp_PayBillApi : IWebApi
    {
        bool Save(Ap_PayBillSaveInputDto Ap_PayBillSaveInputDto);
    }
}