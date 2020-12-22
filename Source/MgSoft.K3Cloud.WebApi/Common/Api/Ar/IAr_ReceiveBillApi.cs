using MgSoft.K3Cloud.WebApi.Common.Dto.Ar;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Ar
{
    public interface IAr_ReceiveBillApi : IWebApi
    {
        bool Save(Ar_ReceiveBillSaveInputDto Ar_ReceiveBillSaveInputDto);
    }
}