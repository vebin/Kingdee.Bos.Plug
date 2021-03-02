using MgSoft.K3Cloud.WebApi.Dto;
using MgSoft.Log;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Services
{
    public class LoginServices: ILoginServices
    {
        private IMgLog log;
        public LoginServices(IMgLogger logger = null)
        {
            if (logger != null)
            {
                log = logger.CreateLog();
            }
            else
            {
                log = new NullMgLog();
            }
        }
        /// <summary>
        /// 测试账号连接登陆
        /// </summary>
        /// <param name="apiServerInfo"></param>
        /// <returns></returns>
        public bool CheckConnect(ApiServerInfo apiServerInfo)
        {
            var result = new K3CloudApiClient(apiServerInfo);
            var loginResult = result.ValidateUser(apiServerInfo.Dbid, apiServerInfo.UserName, apiServerInfo.Password, apiServerInfo.Lcid);
            var resultType = JObject.Parse(loginResult)["LoginResultType"].Value<int>();
            if (resultType != 1)
            {
                log.Error(loginResult);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
