using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApplication.WebAPI;
using Newtonsoft.Json;

namespace MgSoft.K3Cloud.WebApi
{
    public class K3CloudApiClient
    {
        private string url;//K/3 Cloud 业务站点地址
        private HttpClient httpClient;

        public K3CloudApiClient(string url)
        {
            this.url = url;
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
            httpClient.Url = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.AuthService.ValidateUser.common.kdsvc");

            httpClient.Content = GetContents(dbid, userName, password, lcid);

            return httpClient.SysncRequest();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="formId">业务对象标识</param>
        /// <param name="content">请求JSON串</param>
        /// <returns></returns>
        public string Save(string formId, string content)
        {
            httpClient.Url = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Save.common.kdsvc");

            httpClient.Content = GetContents(formId, content);
            return httpClient.SysncRequest();
        }

        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="formId">业务对象标识</param>
        /// <param name="content">请求JSON串</param>
        /// <returns></returns>
        public string Submit(string formId, string content)
        {
            httpClient.Url = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Submit.common.kdsvc");
            httpClient.Content = GetContents(formId, content);
            return httpClient.SysncRequest();
        }

        public string ExecuteBillQuery(string content)
        {
            httpClient.Url = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.ExecuteBillQuery.common.kdsvc");

            httpClient.Content = GetContents(content);
            return httpClient.SysncRequest();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="formId">业务对象标识</param>
        /// <param name="content">请求JSON串</param>
        /// <returns></returns>
        public string Delete(string formId, string content)
        {
            httpClient.Url = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Delete.common.kdsvc");

            httpClient.Content = GetContents(formId, content);

            return httpClient.SysncRequest();
        }

        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="formId">业务对象标识</param>
        /// <param name="content">请求JSON串</param>
        /// <returns></returns>
        public string Audit(string formId, string content)
        {
            httpClient.Url = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Audit.common.kdsvc");

            httpClient.Content = GetContents(formId, content);
            return httpClient.SysncRequest();
        }
        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="formId">业务对象标识</param>
        /// <param name="content">请求JSON串</param>
        /// <returns></returns>
        public string UnAudit(string formId, string content)
        {
            httpClient.Url = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.UnAudit.common.kdsvc");

            httpClient.Content = GetContents(formId, content);

            return httpClient.SysncRequest();
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="formId">业务对象标识</param>
        /// <param name="content">请求JSON串</param>
        /// <returns></returns>
        public string View(string formId, string content)
        {
            httpClient.Url = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.View.common.kdsvc");

            httpClient.Content = GetContents(formId, content);

            return httpClient.SysncRequest();
        }

        /// <summary>
        /// 自定义
        /// </summary>
        /// <param name="key">自定义方法标识</param>
        /// <param name="args">参数</param>
        /// <returns></returns>
        public string AbstractWebApiBusinessService(string key, List<object> args)
        {
            httpClient.Url = string.Concat(url, key, ".common.kdsvc");

            httpClient.Content = JsonConvert.SerializeObject(args);
            return httpClient.SysncRequest();
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
