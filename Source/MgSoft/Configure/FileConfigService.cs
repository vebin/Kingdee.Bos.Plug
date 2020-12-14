using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.Configure
{

    public class FileConfigService : IConfigService
    {
        private string _appPatch;
        public const string DefaultConfigName = "AppConfig.json";
        private Dictionary<string,object> cache=new Dictionary<string, object>();

        public string AppPatch
        {
            get
            {
                if (string.IsNullOrEmpty(_appPatch))
                {
                    _appPatch = AppDomain.CurrentDomain.BaseDirectory;
                }
                return _appPatch;
            }
        }
        public T GetConfig<T>(string configName = DefaultConfigName) where T : class,new()
        {
            if (cache.ContainsKey(configName)) return cache[configName] as T;

            string configFullName = GetConfigFileFullName(DefaultConfigName);

            if (!File.Exists(configFullName))
            {
                return default;
            }
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(configFullName));
        }
        public void SetConfig<T>(T config, string configName = DefaultConfigName)
        {
            File.WriteAllText(GetConfigFileFullName(DefaultConfigName), JsonConvert.SerializeObject(config));
            SetCahce(config, configName);
        }
        private string GetConfigFileFullName(string fileName)
        {
            return AppPatch + fileName;
        }

        private void SetCahce(object config,string configName)
        {
            cache[configName] = config;
        }

        //public int? ToIntOrNull(this string o)
        //{
        //    try
        //    {
        //        return Convert.ToInt32(o);
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
    }
}
