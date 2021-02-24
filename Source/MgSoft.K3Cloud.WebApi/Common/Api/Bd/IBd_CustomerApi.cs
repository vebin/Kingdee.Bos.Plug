using MgSoft.K3Cloud.WebApi.Common.Dto.Bd;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Bd
{
    /// <summary>
    /// 客户
    /// </summary>
    public interface IBd_CustomerApi : IWebApi
    {
        List<SaveOutPutDto> Save(Bd_CustomerSaveInputDto bd_CustomerSaveInputDto);
    }
}
