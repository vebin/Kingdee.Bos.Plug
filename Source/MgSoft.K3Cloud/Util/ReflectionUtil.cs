using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using MgSoft.K3Cloud.WebApi;

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
                if(GetValueAttributeName(property)==valueAttributeName)
                {
                    property.SetValue(target, value,null);
                }
            }
        }

        private static string GetValueAttributeName(PropertyInfo propertyInfo)
        {
            var customAttributes = propertyInfo.GetCustomAttributes(typeof(ValueDicNameAttribute), true);
            if (customAttributes.Any())
            {
                return (customAttributes[0] as ValueDicNameAttribute).Name;
            }
            return "";
        }
    }
}
