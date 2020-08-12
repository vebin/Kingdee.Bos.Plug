using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Dto
{
    /// <summary>
    /// Api初始化基参数
    /// </summary>
    public class ApiServerInfo
    {
        /// <summary>
        /// 服务器地址
        /// </summary>
        public string ServerUrl { get; set; }

        /// <summary>
        /// 账套Id
        /// </summary>
        public string Dbid { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 默认中文
        /// </summary>
        public int Lcid { get; set; } = 2052;
    }
}
