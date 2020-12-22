using MgSoft.K3Cloud.WebApi.Common.Dto.Ap;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Ap
{
    public interface IAp_RefundBillApi : IWebApi
    {
        bool Save(Ap_RefundBillSaveInputDto Ap_RefundBillSaveInputDto);
    }
}