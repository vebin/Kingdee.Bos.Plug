using MgSoft.K3Cloud.WebApi.Common.Dto.Ar;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Ar
{
    public interface IAr_OtherReceivableApi : IWebApi
    {
        bool Save(Ar_OtherReceivableSaveInputDto Ar_OtherReceivableSaveInputDto);
    }
}