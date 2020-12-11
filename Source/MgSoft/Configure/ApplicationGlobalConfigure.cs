using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.Configure
{
    public static class ApplicationGlobalConfigure
    {
        private static IConfigScheduling configScheduling=new FileConfigScheduling();

        public static void SetConfigScheduling(IConfigScheduling configScheduling)
        {
            ApplicationGlobalConfigure.configScheduling = configScheduling;
        }

        public static T GetConfig<T>() where T:class,new()
        {
            return configScheduling.GetConfig<T>();
        }

        public static void SetConfig(object config)
        {
            configScheduling.SetConfig(config);
        }
    }
}
