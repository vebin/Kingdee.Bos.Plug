using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.Configure
{

    public class FileConfigScheduling : IConfigScheduling
    {
        private string _appPatch;
        public const string DefaultConfigName = "AppConfig.json";

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
        }
        private string GetConfigFileFullName(string fileName)
        {
            return AppPatch + fileName;
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
