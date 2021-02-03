using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Configure
{
    public class MemoryConfigService : IConfigService
    {
        Dictionary<string, object> memoryConfig=new Dictionary<string, object>();

        object lockOjbect = new object();

        public T GetConfig<T>(string configName = "") where T : class, new()
        {
            if (string.IsNullOrEmpty(configName)) configName = typeof(T).FullName;

            lock (lockOjbect)
            {
                if (memoryConfig.ContainsKey(configName))
                {
                    return memoryConfig[configName] as T;
                }
            }
            return null;
        }

        public void SetConfig<T>(T config, string configName = "")
        {
            if (string.IsNullOrEmpty(configName)) configName = typeof(T).FullName;
            lock (lockOjbect)
            {
                memoryConfig[configName] = config;
            }
        }
    }
}
