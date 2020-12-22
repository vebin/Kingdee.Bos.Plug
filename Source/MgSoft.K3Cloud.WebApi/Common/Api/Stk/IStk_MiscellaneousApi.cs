using MgSoft.K3Cloud.WebApi.Common.Dto.Stk;
using MgSoft.K3Cloud.WebApi.Dto;
using System.Collections.Generic;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Stk
{
    public interface IStk_MiscellaneousApi : IWebApi
    {
        List<SaveOutPutDto> Save(Stk_MiscellaneousSaveInputDto stk_MiscellaneousSaveInputDto);
    }
}