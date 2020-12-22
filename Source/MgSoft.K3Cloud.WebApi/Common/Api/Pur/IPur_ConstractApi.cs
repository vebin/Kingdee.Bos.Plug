using MgSoft.K3Cloud.WebApi.Common.Dto.Pur;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Pur
{
    public interface IPur_ConstractApi : IWebApi
    {
        bool Save(Pur_ConstractSaveInputDto Pur_ConstractSaveInputDto);
    }
}