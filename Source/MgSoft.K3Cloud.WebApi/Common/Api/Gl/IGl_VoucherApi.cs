using MgSoft.K3Cloud.WebApi.Common.Dto.Gl;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Gl
{
    public interface IGl_VoucherApi : IWebApi
    {
        bool Save(Gl_VoucherSaveInputDto Gl_VoucherSaveInputDto);
    }
}