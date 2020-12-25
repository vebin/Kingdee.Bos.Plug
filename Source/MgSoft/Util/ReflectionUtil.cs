using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;

namespace MgSoft.Util
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
                if (GetPropertyMapNameAttributeName(property) == valueAttributeName)
                {
                    property.SetValue(target, value, null);
                }
            }
        }        
        
        /// <summary>
        /// 根据ValueAttribute注解，给对像进行赋值
        /// </summary>
        /// <param name="target"></param>
        /// <param name="valueAttributeName"></param>
        /// <param name="value"></param>
        public static void SetValueByAttribute(object target, string valueAttributeName, JToken value)
        {
            var targetType = target.GetType();
            foreach (var property in targetType.GetProperties())
            {
                if (GetPropertyMapNameAttributeName(property) == valueAttributeName)
                {
                    property.SetValue(target, value.ToObject(property.PropertyType), null);
                }
            }
        }

        public static string GetPropertyMapNameAttributeName(PropertyInfo propertyInfo)
        {
            var customAttributes = propertyInfo.GetCustomAttributes(typeof(JsonPropertyAttribute), true);
            if (customAttributes.Any())
            {
                return (customAttributes[0] as JsonPropertyAttribute).PropertyName;
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

        /// <summary>
        /// 根据枚举值，获取描述
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string GetEnumDes(Enum enumValue)
        {
            string value = enumValue.ToString();
            FieldInfo field = enumValue.GetType().GetField(value);
            object[] objs = field.GetCustomAttributes(typeof(DescriptionAttribute), false);    //获取描述属性
            if (objs == null || objs.Length == 0)    //当描述属性没有时，直接返回名称
                return value;
            DescriptionAttribute descriptionAttribute = (DescriptionAttribute)objs[0];
            return descriptionAttribute.Description;
        }
    }
}
