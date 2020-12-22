using MgSoft.K3Cloud.WebApi.Common.Dto.Ar;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Ar
{
    public interface IAr_ReceivableApi : IWebApi
    {
        bool Save(Ar_ReceivableSaveInputDto Ar_ReceivableSaveInputDto);
    }
}