using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.Configure
{
    public static class ApplicationGlobalConfigure
    {
        private static IConfigService configScheduling=new FileConfigService();//默认使用文件配置

        public static void SetConfigScheduling(IConfigService configScheduling)
        {
            ApplicationGlobalConfigure.configScheduling = configScheduling;
        }

        public static T GetConfig<T>() where T:class,new()
        {
            return configScheduling.GetConfig<T>();
        }

        public static void SetConfig<T>(T config)
        {
            configScheduling.SetConfig(config);
        }
    }
}
