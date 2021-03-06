﻿using MgSoft.K3Cloud.WebApi.Dto;
using MgSoft.Log;
using MgSoft.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.WebApi
{
    public abstract class BaseApi : IWebApi
    {
        private static List<K3CloudApiClient> k3CloudApiClientCache = new List<K3CloudApiClient>();
        private static object lockObject = new object();
        public ApiServerInfo ApiServerInfo { get; private set; }
#if DEBUG
        private const int TimeOutSecond = 3 * 60;
#else
        private const int TimeOutSecond = 10 * 60;
#endif

        /// <summary>
        /// 超时重试次数
        /// </summary>
        private static int retryCount = 0;

        //public static DateTime CreateTime { get; private set; } = DateTime.Now;
        protected IMgLog log;

        protected K3CloudApiClient client
        {
            get
            {
                lock (lockObject)
                {
                    var result = getK3CloudApiClientFormCache(this.ApiServerInfo);

                    if (result == null)
                    {
                        result = createK3CloudApiClient();
                        setK3CloudApiClientFormCache(result);
                    }
                    return result;
                }
            }
        }

        protected abstract string formId { get; }

        /// <summary>
        /// </summary>
        /// <param name="serverUrl">服务器地址</param>
        /// <param name="dbid">数据库账套Id</param>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="lcid">语言Id，默认为中文2052</param>
        public BaseApi(string serverUrl, string dbid, string userName, string password, int lcid = 2052)
            : this(new ApiServerInfo() { ServerUrl = serverUrl, Dbid = dbid, UserName = userName, Password = password, Lcid = lcid })
        {
        }

        protected BaseApi(ApiServerInfo apiServerInfo, IMgLogger logger = null)
        {
            this.ApiServerInfo = apiServerInfo;
            if (logger != null)
            {
                log = logger.CreateLog();
            }
            else
            {
                log = new NullMgLog();
            }
        }

        private K3CloudApiClient getK3CloudApiClientFormCache(ApiServerInfo apiServerInfo)
        {
            var cacheObj = k3CloudApiClientCache.Where(p => p.ApiServerInfo.Equals(p.ApiServerInfo)).SingleOrDefault();
            if (cacheObj == null) return null;
            if (isClientTimeOut(cacheObj.CreateTime))
            {
                removeK3CloudApiClientFormCache(cacheObj);
                //cacheObj.CreateTime = DateTime.Now;
                return null;
            }
            return cacheObj;
        }
        private void setK3CloudApiClientFormCache(K3CloudApiClient k3CloudApiClient)
        {
            k3CloudApiClientCache.Add(k3CloudApiClient);
        }

        private void removeK3CloudApiClientFormCache(K3CloudApiClient k3CloudApiClient)
        {
            var removeObj = k3CloudApiClientCache.Where(p => p.ApiServerInfo.Equals(p.ApiServerInfo)).SingleOrDefault();
            if (removeObj == null) return;

            k3CloudApiClientCache.Remove(removeObj);
        }

        private bool isClientTimeOut(DateTime createTime)
        {
            var result = (DateTime.Now - createTime).Ticks > TimeOutSecond;
            return result;
        }

        private K3CloudApiClient createK3CloudApiClient()
        {
            var result = new K3CloudApiClient(this.ApiServerInfo);
            var loginResult = result.ValidateUser(this.ApiServerInfo.Dbid, this.ApiServerInfo.UserName, this.ApiServerInfo.Password, this.ApiServerInfo.Lcid);
            var resultType = JObject.Parse(loginResult)["LoginResultType"].Value<int>();
            if (resultType != 1)
            {
                throw new Exception(loginResult);
            }

            return result;
        }


        /// <summary>
        /// 获取列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="getListInputDto"></param>
        /// <param name="serializeIndexFields">
        /// 序列化的顺序，需要配合FieldKeys进行修改
        /// 由于api返回的结果是一个扁平的数组
        /// indexFields的作用是，使行数组的位置与要序列化的字段作对应，例如:BillNo在第0位，把数组的第0位序列话给BillNo
        /// </param>
        /// <returns></returns>
        public List<T> GetList<T>(GetListInputDto getListInputDto) where T : class, new()
        {
            setFormId(getListInputDto);

            string fileds = getListInputDto.FieldKeys;
            if (fileds == null || fileds.Length == 0)
            {
                fileds = getFieldsByPropertyMapName<T>();
            }
            getListInputDto.FieldKeys = fileds;

            var apiResult = client.ExecuteBillQuery(JsonConvert.SerializeObject(getListInputDto));

            CheckGetListIsSuccess(apiResult);

            return SerializeToPocoList<T>(apiResult, fileds);
        }


        public T Get<T>(string formId, long id) where T : class
        {
            return Get<T>(new GetInputDto()
            {
                Id = id
            });
        }

        public T Get<T>(string formId, string number) where T : class
        {
            return Get<T>(new GetInputDto()
            {
                Number = number
            });
        }

        public T Get<T>(GetInputDto getInputDto) where T : class
        {
            setFormId(getInputDto);

            var apiResult = client.View(getInputDto.FormId, JsonConvert.SerializeObject(getInputDto));

            CheckGetIsSuccess(apiResult);

            var jObject = JObject.Parse(apiResult);
            var data = jObject["Result"]["Result"].ToString();
            return JsonConvert.DeserializeObject<T>(data);
        }

        public bool Exist(string filterString, string fileds = "FId")
        {
            var getListInputDto = new GetListInputDto()
            {
                FieldKeys = fileds,
                FilterString = filterString
            };

            setFormId(getListInputDto);
            var apiResult = client.ExecuteBillQuery(JsonConvert.SerializeObject(getListInputDto));

            CheckGetListIsSuccess(apiResult);

            var result = JsonConvert.DeserializeObject<List<string>>(apiResult);
            return result.Count > 0;
        }

        //public SaveOutPutDto Save(SaveInputDto saveInputDto)
        //{
        //    var apiResult = client.Save(saveInputDto.FormId, JsonConvert.SerializeObject(saveInputDto));
        //    CheckGetIsSuccess(apiResult);
        //}

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="saveInputDto"></param>
        /// <returns></returns>
        public virtual List<SaveOutPutDto> Save(SaveInputDto saveInputDto)
        {
            setFormId(saveInputDto);

            
            var apiResult = client.Save(saveInputDto.FormId, JsonConvert.SerializeObject(saveInputDto));
            CheckGetIsSuccess(apiResult);

            return JsonConvert.DeserializeObject<List<SaveOutPutDto>>(GetData(apiResult));
        }

        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="submitInputDto"></param>
        /// <returns></returns>
        public List<SubmitOutputDto> Submit(SubmitInputDto submitInputDto)
        {
            setFormId(submitInputDto);

            var apiResult = client.Submit(submitInputDto.FormId, JsonConvert.SerializeObject(submitInputDto));
            CheckGetIsSuccess(apiResult);

            return JsonConvert.DeserializeObject<List<SubmitOutputDto>>(GetData(apiResult));
        }
        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="auditInputDto"></param>
        /// <returns></returns>
        public List<AuditOutputDto> Audit(AuditInputDto auditInputDto)
        {
            setFormId(auditInputDto);

            var apiResult = client.Audit(auditInputDto.FormId, JsonConvert.SerializeObject(auditInputDto));
            CheckGetIsSuccess(apiResult);

            return JsonConvert.DeserializeObject<List<AuditOutputDto>>(GetData(apiResult));
        }
        /// <summary>
        /// 反审核
        /// </summary>
        /// <param name="unAuditInputDto"></param>
        /// <returns></returns>
        public List<UnAuditOutputDto> UnAudit(UnAuditInputDto unAuditInputDto)
        {
            setFormId(unAuditInputDto);

            var apiResult = client.UnAudit(unAuditInputDto.FormId, JsonConvert.SerializeObject(unAuditInputDto));
            CheckGetIsSuccess(apiResult);

            return JsonConvert.DeserializeObject<List<UnAuditOutputDto>>(GetData(apiResult));
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="deleteInputDto"></param>
        /// <returns></returns>
        public List<DeleteOutputDto> Delete(DeleteInputDto deleteInputDto)
        {
            setFormId(deleteInputDto);

            var apiResult = client.Delete(deleteInputDto.FormId, JsonConvert.SerializeObject(deleteInputDto));
            CheckGetIsSuccess(apiResult);

            return JsonConvert.DeserializeObject<List<DeleteOutputDto>>(GetData(apiResult));
        }
        /// <summary>
        /// 下推
        /// </summary>
        /// <param name="PushInputDto"></param>
        /// <returns></returns>
        public List<PushOutputDto> Push(PushInputDto PushInputDto)
        {
            setFormId(PushInputDto);

            var apiResult = client.Push(PushInputDto.FormId, JsonConvert.SerializeObject(PushInputDto));
            CheckGetIsSuccess(apiResult);

            return JsonConvert.DeserializeObject<List<PushOutputDto>>(GetData(apiResult));
        }


        #region 私有方法
        private void setFormId(BaseApiDto baseApiDto)
        {
            baseApiDto.FormId = this.formId;
        }

        private string getFieldsByPropertyMapName<T>() where T : class, new()
        {
            var mapNameList = ReflectionUtil.GetPropertyMapNameAttributeNameList<T>();

            if (mapNameList.Count == 0)
            {
                return "";
            }

            var result = new StringBuilder();
            foreach (var mapName in mapNameList)
            {
                result.Append($"{mapName},");
            }
            result.Remove(result.Length - 1, 1);

            return result.ToString();
        }
        private void CheckGetListIsSuccess(string apiResult)
        {
            JArray jResult = JArray.Parse(apiResult);
            if (jResult == null || jResult.Count == 0 || jResult[0].Count() == 0 || jResult[0][0].SelectToken("Result") == null)
            {
                return;
            }
            CheckIsSuccess(jResult[0][0].SelectToken("Result"));
        }

        private void CheckGetIsSuccess(string apiResult)
        {
            var jResult = JObject.Parse(apiResult)?["Result"];
            CheckIsSuccess(jResult);
        }

        private void CheckIsSuccess(JToken jResult)
        {
            if (jResult == null || jResult.SelectToken("ResponseStatus") == null)
            {
                return;
            }

            
            var responseStatus = jResult["ResponseStatus"];

            var msgCode = responseStatus?["MsgCode"]?.Value<int>() ?? 0;
            if (msgCode.Equals(1))//是否超时。1 为超时。其他值暂不知晓，后续可以补充
            {
                var cacheObj = k3CloudApiClientCache.Where(p => p.ApiServerInfo.Equals(p.ApiServerInfo)).SingleOrDefault();
                if (cacheObj == null) return;
                removeK3CloudApiClientFormCache(cacheObj);
            }
            if (responseStatus.SelectToken("IsSuccess") != null && responseStatus["IsSuccess"].Value<bool>())
            {
                return;
            }
            if (responseStatus.SelectToken("Errors") != null)
            {
                //throw new ApiException(responseStatus["Errors"].ToString());                
                throw new ApiException(getErrorMessage(responseStatus));
            }
        }

        private string GetData(string apiResult)
        {
            if (!string.IsNullOrEmpty(apiResult))
            {
                var jObject = JObject.Parse(apiResult);
                return jObject["Result"]["ResponseStatus"]["SuccessEntitys"].ToString();
            }
            return "";
        }

        private List<T> SerializeToPocoList<T>(string queryList, string fieldKeys) where T : class, new()
        {
            var result = new List<T>();
            string[] fieldKeysArray = fieldKeys.Split(',');

            JArray jarray = JArray.Parse(queryList);

            foreach (var row in jarray)
            {
                T data = new T();
                for (int fieldIndex = 0; fieldIndex < fieldKeysArray.Length; fieldIndex++)
                {
                    string fieldKey = fieldKeysArray[fieldIndex];
                    ReflectionUtil.SetValueByAttribute(data, fieldKey, row[fieldIndex]);
                }

                result.Add(data);
            }

            return result;
        }


        private string getErrorMessage(JToken errorToken)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < errorToken["Errors"].Count(); i++)
            {
                sb.Append($"{i + 1}、{errorToken["Errors"][i]["Message"]}\r\n");
            }

            return sb.ToString();
        }


        //private object JTokenToObject(JToken jtoken)
        //{
        //    switch (jtoken.Type)
        //    {
        //        case JTokenType.String: return jtoken.Value<string>();
        //        case JTokenType.Integer: return jtoken.Value<int>();
        //        case JTokenType.Float: return jtoken.Value<float>();
        //        case JTokenType.Boolean: return jtoken.Value<bool>();
        //        case JTokenType.Date: return jtoken.Value<DateTime>();
        //        case JTokenType.Null: return null;
        //        default:
        //            throw new Exception("不支持的类型转换");
        //    }
        //}

        //private List<T> SerializeToPocoList<T>(List<List<Object>> queryList, string[] indexFields)
        //{
        //    JArray jArray = new JArray();
        //    foreach (var row in queryList)
        //    {
        //        JObject data = new JObject();
        //        for (int cellIndex = 0; cellIndex < row.Count; cellIndex++)
        //        {
        //            data.Add(indexFields[cellIndex], row[cellIndex].ToString());
        //        }
        //        jArray.Add(data);
        //    }

        //    return JsonConvert.DeserializeObject<List<T>>(jArray.ToString());
        //}

        #endregion
    }
}
