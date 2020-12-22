using MgSoft.K3Cloud.WebApi.Common.Dto.Bd;
using MgSoft.K3Cloud.WebApi.Dto;
using System.Collections.Generic;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Bd
{
    public interface IBd_MaterialApi : IWebApi
    {
        List<SaveOutPutDto> Save(Bd_MaterialSaveInputDto bd_MaterialSaveInputDto);
    }
}