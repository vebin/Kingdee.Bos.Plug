using MgSoft.K3Cloud.WebApi.Common.Dto.Ap;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Ap
{
    public interface IAp_OtherPayableApi : IWebApi
    {
        bool Save(Ap_OtherPayableSaveInputDto Ap_OtherPayableSaveInputDto);
    }
}