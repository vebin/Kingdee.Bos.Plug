﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Diagnostics;

namespace ConsoleApplication.WebAPI
{
    class HttpClient
    {
        ///// <summary>
        ///// Seivice URL
        ///// </summary>
        //public string Url { get; set; }
        ///// <summary>
        ///// 内容
        ///// </summary>
        //public string Content { get; set; }
        /// <summary>
        /// Cookie，保证登录后，所有访问持有一个Cookie；
        /// </summary>
        private CookieContainer Cookie = new CookieContainer();

        /// <summary>
        /// HTTP访问
        /// </summary>
        public string SysncRequest(string url, string content)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var result = sysncRequest(url,content);
            stopwatch.Stop();
            System.Diagnostics.Debug.WriteLine(url);
            System.Diagnostics.Debug.WriteLine($"秒:{stopwatch.ElapsedMilliseconds / 1000},实际用时毫秒:{stopwatch.ElapsedMilliseconds}");
            return result;

        }

        private string sysncRequest(string url, string content)
        {
            HttpWebRequest httpRequest = HttpWebRequest.Create(url) as HttpWebRequest;
            httpRequest.Method = "POST";
            httpRequest.ContentType = "application/json";
            httpRequest.CookieContainer = Cookie;
            httpRequest.Timeout = 1000 * 60 * 10;//10min

            using (Stream reqStream = httpRequest.GetRequestStream())
            {
                JObject jObj = new JObject();
                jObj.Add("format", 1);
                jObj.Add("useragent", "ApiClient");
                jObj.Add("rid", Guid.NewGuid().ToString().GetHashCode().ToString());
                jObj.Add("parameters", content);
                jObj.Add("timestamp", DateTime.Now);
                jObj.Add("v", "1.0");
                string sContent = jObj.ToString();
                var bytes = UnicodeEncoding.UTF8.GetBytes(sContent);
                reqStream.Write(bytes, 0, bytes.Length);
                reqStream.Flush();
            }


            using (var repStream = httpRequest.GetResponse().GetResponseStream())
            {
                using (var reader = new StreamReader(repStream))
                {
                    return ValidateResult(reader.ReadToEnd());
                }
            }
        }

        private static string ValidateResult(string responseText)
        {
            if (responseText.StartsWith("response_error:"))
            {
                var failText = responseText.TrimStart("response_error:".ToCharArray());
            }
            return responseText;
        }
    }
}