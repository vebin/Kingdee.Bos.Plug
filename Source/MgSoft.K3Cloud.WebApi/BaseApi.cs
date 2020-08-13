using MgSoft.K3Cloud.WebApi.Dto;
using MgSoft.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.WebApi
{
    public abstract class BaseApi
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
            client = new K3CloudApiClient(serverUrl);
            var loginResult = client.ValidateUser(dbid, userName, password, lcid);
            var resultType = JObject.Parse(loginResult)["LoginResultType"].Value<int>();
            if (resultType != 1)
            {
                throw new Exception(loginResult);
            }
        }

        protected BaseApi(ApiServerInfo apiServerInfo)
            : this(apiServerInfo.ServerUrl, apiServerInfo.Dbid, apiServerInfo.UserName, apiServerInfo.Password, apiServerInfo.Lcid)
        {
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
                FormId = formId,
                Id = id
            });
        }

        public T Get<T>(string formId, string number) where T : class
        {
            return Get<T>(new GetInputDto()
            {
                FormId = formId,
                Number = number
            });
        }

        public T Get<T>(GetInputDto getInputDto) where T : class
        {
            var apiResult = client.View(getInputDto.FormId, JsonConvert.SerializeObject(getInputDto));
            
            CheckGetIsSuccess(apiResult);

            var jObject = JObject.Parse(apiResult);
            var data = jObject["Result"]["Result"].ToString();
            return JsonConvert.DeserializeObject<T>(data);
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
            if(jResult==null|| jResult.Count==0|| jResult[0].Count()==0||jResult[0][0].SelectToken("Result")==null)
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
            if (jResult==null|| jResult.SelectToken("ResponseStatus") == null)
            {
                return;
            }
            var responseStatus = jResult["ResponseStatus"];
            if (responseStatus.SelectToken("Errors")!=null)
            { 
                throw new ApiException(responseStatus["Errors"].ToString());
            }
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
    }
}
