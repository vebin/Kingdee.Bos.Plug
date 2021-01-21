using MgSoft.K3Cloud.WebApi.Dto;
using MgSoft.K3Cloud.WebApi.ServiceApi.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi
{
    public class K3CloudDataCenterApi : IK3CloudDataCenterApi
    {
        private readonly string serverUrl;
        private HttpClient httpClient;

        public K3CloudDataCenterApi(ApiServerInfo apiServerInfo)
            : this(apiServerInfo.ServerUrl)
        {
        }

        public K3CloudDataCenterApi(string serverUrl)
        {
            this.serverUrl = serverUrl;
            httpClient = new HttpClient();
        }

        /// <summary>
        /// 获取数据中心
        /// </summary>
        /// <returns></returns>
        public List<DataCenterDto> GetDataCenter()
        {
            var httpUrl = string.Concat(serverUrl, "Kingdee.BOS.ServiceFacade.ServicesStub.Account.AccountService.GetDataCenterList.common.kdsvc");

            var httpContent = "";
            var requestString = httpClient.SysncRequest(httpUrl, httpContent);
            return JsonConvert.DeserializeObject<List<DataCenterDto>>(requestString);
        }
    }
}
