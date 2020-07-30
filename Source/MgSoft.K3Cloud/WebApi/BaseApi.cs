using Kingdee.BOS.WebApi.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.WebApi
{
    public class BaseApi
    {
        protected K3CloudApiClient client;

        /// <summary>
        /// </summary>
        /// <param name="serverUrl">服务器地址</param>
        /// <param name="dbid">数据库账套Id</param>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="lcid">语言Id，默认为中文2052</param>
        public BaseApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052)
        {
            K3CloudApiClient client = new K3CloudApiClient(serverUrl);
            var loginResult = client.ValidateLogin(dbid, userName, password, lcid);
            var resultType = JObject.Parse(loginResult)["LoginResultType"].Value<int>();
            if (resultType != 1)
            {
                throw new MgBusinessException(loginResult);
            }
        }
    }
}
