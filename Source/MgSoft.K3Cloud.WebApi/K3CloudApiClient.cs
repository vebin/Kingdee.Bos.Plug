using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MgSoft.K3Cloud.WebApi.Dto;
using Newtonsoft.Json;

namespace MgSoft.K3Cloud.WebApi
{
    public class K3CloudApiClient
    {
        private string url;//K/3 Cloud 业务站点地址
        private HttpClient httpClient;

        public ApiServerInfo ApiServerInforl { get; private set; }

        public DateTime CreateTime { get; private set; } = DateTime.Now;

        //public int LoginTimeOutSecond = 5 * 60;

        //public bool IsTimeOut()
        //{
        //    if (!LastLoginTime.HasValue) return true;
        //    return (DateTime.Now - LastLoginTime.Value).Seconds > LoginTimeOutSecond;
        //}

        public K3CloudApiClient(ApiServerInfo apiServerInforl)
        {
            this.ApiServerInforl = apiServerInforl;
            this.url = apiServerInforl.ServerUrl;
            httpClient = new HttpClient();
        }

        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="dbid">账套标示</param>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="lcid">2052代表中文</param>
        /// <returns></returns>
        public string ValidateUser(string dbid, string userName, string password, int lcid = 2052)
        {
            var httpUrl = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.AuthService.ValidateUser.common.kdsvc");

            var httpContent = GetContents(dbid, userName, password, lcid);
            return httpClient.SysncRequest(httpUrl, httpContent);
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="formId">业务对象标识</param>
        /// <param name="content">请求JSON串</param>
        /// <returns></returns>
        public string Save(string formId, string content)
        {
            var httpUrl = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Save.common.kdsvc");

            var httpContent = GetContents(formId, content);
            return httpClient.SysncRequest(httpUrl, httpContent);
        }

        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="formId">业务对象标识</param>
        /// <param name="content">请求JSON串</param>
        /// <returns></returns>
        public string Submit(string formId, string content)
        {
            var httpUrl = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Submit.common.kdsvc");
            var httpContent = GetContents(formId, content);
            return httpClient.SysncRequest(httpUrl, httpContent);
        }

        public string ExecuteBillQuery(string content)
        {
            var httpUrl = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.ExecuteBillQuery.common.kdsvc");

            var httpContent = GetContents(content);
            return httpClient.SysncRequest(httpUrl, httpContent);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="formId">业务对象标识</param>
        /// <param name="content">请求JSON串</param>
        /// <returns></returns>
        public string Delete(string formId, string content)
        {
            var httpUrl = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Delete.common.kdsvc");

            var httpContent = GetContents(formId, content);

            return httpClient.SysncRequest(httpUrl, httpContent);
        }

        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="formId">业务对象标识</param>
        /// <param name="content">请求JSON串</param>
        /// <returns></returns>
        public string Audit(string formId, string content)
        {
            var httpUrl = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Audit.common.kdsvc");

            var httpContent = GetContents(formId, content);
            return httpClient.SysncRequest(httpUrl, httpContent);
        }
        /// <summary>
        /// 反审核
        /// </summary>
        /// <param name="formId">业务对象标识</param>
        /// <param name="content">请求JSON串</param>
        /// <returns></returns>
        public string UnAudit(string formId, string content)
        {
            var httpUrl = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.UnAudit.common.kdsvc");

            var httpContent = GetContents(formId, content);

            return httpClient.SysncRequest(httpUrl, httpContent);
        }
        /// <summary>
        /// 下推
        /// </summary>
        /// <param name="formId">业务对象标识</param>
        /// <param name="content">请求Json串</param>
        /// <returns></returns>
        public string Push(string formId, string content)
        {
            var httpUrl = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Push.common.kdsvc");

            var httpContent = GetContents(formId, content);

            return httpClient.SysncRequest(httpUrl, httpContent);
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="formId">业务对象标识</param>
        /// <param name="content">请求JSON串</param>
        /// <returns></returns>
        public string View(string formId, string content)
        {
            var httpUrl = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.View.common.kdsvc");

            var httpContent = GetContents(formId, content);

            return httpClient.SysncRequest(httpUrl, httpContent);
        }

        /// <summary>
        /// 自定义
        /// </summary>
        /// <param name="key">自定义方法标识</param>
        /// <param name="args">参数</param>
        /// <returns></returns>
        public string AbstractWebApiBusinessService(string key, List<object> args)
        {
            var httpUrl = string.Concat(url, key, ".common.kdsvc");

            var httpContent = JsonConvert.SerializeObject(args);
            return httpClient.SysncRequest(httpUrl, httpContent);
        }


        #region 私有方法
        private string GetContents(params Object[] objs)
        {
            List<object> Parameters = new List<object>();
            foreach (var obj in objs)
            {
                Parameters.Add(obj);
            }
            return JsonConvert.SerializeObject(Parameters);
        }
        #endregion
    }
}
