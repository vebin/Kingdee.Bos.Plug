using MgSoft.K3Cloud.WebApi.Common.Dto.Pur;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Pur
{
    public interface IPur_MrbApi : IWebApi
    {
        bool Save(Pur_MrbSaveInputDto Pur_MrbSaveInputDto);
    }
}