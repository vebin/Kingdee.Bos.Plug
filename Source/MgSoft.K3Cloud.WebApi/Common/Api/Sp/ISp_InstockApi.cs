using MgSoft.K3Cloud.WebApi.Common.Dto.Sp;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Sp
{
    public interface ISp_InstockApi : IWebApi
    {
        bool Save(Sp_InstockSaveInputDto sp_InstockSaveInputDto);
    }
}