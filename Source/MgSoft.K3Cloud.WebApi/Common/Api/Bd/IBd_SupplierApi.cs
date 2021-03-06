﻿using MgSoft.K3Cloud.WebApi.Common.Dto.Bd;
using MgSoft.K3Cloud.WebApi.Dto;
using System.Collections.Generic;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Bd
{
    /// <summary>
    /// 供应商
    /// </summary>
    public interface IBd_SupplierApi : IWebApi
    {
        List<SaveOutPutDto> Save(Bd_SupplierSaveInputDto bd_SupplierSaveInputDto);
    }
}