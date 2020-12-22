using MgSoft.K3Cloud.WebApi.Common.Dto.Ap;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Ap
{
    public interface IAp_PayableApi : IWebApi
    {
        bool Save(Ap_PayableSaveInputDto Ap_PayableSaveInputDto);
    }
}