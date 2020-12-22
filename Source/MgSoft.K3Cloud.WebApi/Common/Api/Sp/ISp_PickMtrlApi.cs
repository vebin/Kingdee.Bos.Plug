using MgSoft.K3Cloud.WebApi.Common.Dto.Sp;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Sp
{
    public interface ISp_PickMtrlApi : IWebApi
    {
        bool Save(Sp_PickMtrlSaveInputDto sp_PickMtrlSaveInputDto);
    }
}