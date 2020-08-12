using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;

namespace MgSoft.K3Cloud.Util
{
    public static class ReflectionUtil
    {
        /// <summary>
        /// 根据ValueAttribute注解，给对像进行赋值
        /// </summary>
        /// <param name="target"></param>
        /// <param name="valueAttributeName"></param>
        /// <param name="value"></param>
        public static void SetValueByAttribute(object target, string valueAttributeName, object value)
        {
            var targetType = target.GetType();
            foreach (var property in targetType.GetProperties())
            {
                if(GetPropertyMapNameAttributeName(property)==valueAttributeName)
                {
                    property.SetValue(target, value,null);
                }
            }
        }

        public static string GetPropertyMapNameAttributeName(PropertyInfo propertyInfo)
        {
            var customAttributes = propertyInfo.GetCustomAttributes(typeof(PropertyMapNameAttribute), true);
            if (customAttributes.Any())
            {
                return (customAttributes[0] as PropertyMapNameAttribute).Name;
            }
            return "";
        }

        public static List<string> GetPropertyMapNameAttributeNameList<T>()
        {
            List<string> result = new List<string>();
            var targetType = typeof(T);
            foreach (var property in targetType.GetProperties())
            {
                string mapName = GetPropertyMapNameAttributeName(property);
                if (!string.IsNullOrEmpty(mapName))
                {
                    result.Add(mapName);
                }
            }

            return result;
        }
    }
}
