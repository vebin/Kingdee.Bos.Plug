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
        public string ValidateUser(string dbid, string userName, string password, int lcid)
        {
            httpClient.Url = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.AuthService.ValidateUser.common.kdsvc");

            List<object> Parameters = new List<object>();
            Parameters.Add(dbid);//账套标示
            Parameters.Add(userName);//用户名
            Parameters.Add(password);//密码
            Parameters.Add(lcid);//2052代表中文
            httpClient.Content = JsonConvert.SerializeObject(Parameters);

            return httpClient.SysncRequest();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public string Save(string formId, string content)
        {
            httpClient.Url = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Save.common.kdsvc");

            List<object> Parameters = new List<object>();
            //业务对象Id 
            Parameters.Add(formId);
            //Json字串
            Parameters.Add(content);
            httpClient.Content = JsonConvert.SerializeObject(Parameters);
            return httpClient.SysncRequest();
        }

        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public string Submit(string formId, string content)
        {
            httpClient.Url = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Submit.common.kdsvc");

            List<object> Parameters = new List<object>();
            //业务对象Id 
            Parameters.Add(formId);
            //Json字串
            Parameters.Add(content);
            httpClient.Content = JsonConvert.SerializeObject(Parameters);
            return httpClient.SysncRequest();
        }

        public string ExecuteBillQuery(string content)
        {
            httpClient.Url = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.ExecuteBillQuery.common.kdsvc");

            List<object> Parameters = new List<object>();
            ////业务对象Id 
            //Parameters.Add(formId);
            //Json字串
            Parameters.Add(content);
            httpClient.Content = JsonConvert.SerializeObject(Parameters);
            return httpClient.SysncRequest();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public string Delete(string formId, string content)
        {
            httpClient.Url = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Delete.common.kdsvc");

            List<object> Parameters = new List<object>();
            //业务对象Id 
            Parameters.Add(formId);
            //Json字串
            Parameters.Add(content);
            httpClient.Content = JsonConvert.SerializeObject(Parameters);
            return httpClient.SysncRequest();
        }

        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public string Audit(string formId, string content)
        {
            httpClient.Url = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Audit.common.kdsvc");

            List<object> Parameters = new List<object>();
            //业务对象Id 
            Parameters.Add(formId);
            //Json字串
            Parameters.Add(content);
            httpClient.Content = JsonConvert.SerializeObject(Parameters);
            return httpClient.SysncRequest();
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public string View(string formId, string content)
        {
            httpClient.Url = string.Concat(url, "Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.View.common.kdsvc");

            List<object> Parameters = new List<object>();
            //业务对象Id 
            Parameters.Add(formId);
            //Json字串
            Parameters.Add(content);
            httpClient.Content = JsonConvert.SerializeObject(Parameters);
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
    }
}
