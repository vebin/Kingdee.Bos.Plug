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

        public override bool Equals(object obj)
        {
            var target = obj as ApiServerInfo;
            if (target == null) return false;
            if (this.ServerUrl != target.ServerUrl) return false;
            if (this.Dbid != target.Dbid) return false;
            if (this.UserName != target.UserName) return false;
            if (this.Password != target.Password) return false;
            if (this.Lcid != target.Lcid) return false;

            return true;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
