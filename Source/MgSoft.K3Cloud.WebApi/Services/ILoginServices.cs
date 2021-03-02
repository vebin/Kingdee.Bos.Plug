using MgSoft.K3Cloud.WebApi.Dto;

namespace MgSoft.K3Cloud.WebApi.Services
{
    public interface ILoginServices
    {
        bool CheckConnect(ApiServerInfo apiServerInfo);
    }
}