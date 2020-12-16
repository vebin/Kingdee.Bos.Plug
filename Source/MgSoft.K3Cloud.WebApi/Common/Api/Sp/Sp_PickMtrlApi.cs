using MgSoft.K3Cloud.WebApi.Common.Dto.Sp;
using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Sp
{
    /// <summary>
    /// 简单生产领料ApI
    /// </summary>
    public class Sp_PickMtrlApi : BaseApi
    {
        protected override string formId => "Sp_PickMtrl";
        public Sp_PickMtrlApi(ApiServerInfo apiServerInfo) : base(apiServerInfo)
        {
        }

        public Sp_PickMtrlApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052) : base(serverUrl, dbid, userName, password, lcid)
        {
        }

        public bool Save(Sp_PickMtrlSaveInputDto sp_PickMtrlSaveInputDto)
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = sp_PickMtrlSaveInputDto
            });
            return true;
        }


        public bool Save<T>(T sp_PickMtrlSaveInputDto) where T : Sp_PickMtrlSaveInputDto
        {
            base.Save(new SaveInputDto
            {
                FormId = formId,
                Model = sp_PickMtrlSaveInputDto
            });
            return true;
        }
    }
}
