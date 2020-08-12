using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MgSoft.K3Cloud.Test
{
    [TestClass]
    public class ApiTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //apiServerInfo = new ApiServerInfo()
            //{
            //    ServerUrl = "http://hy.gxjgjt.com:10080/k3cloud/",
            //    Dbid = "5f0686e0d50478",
            //    UserName = "administrator",
            //    Password = "gxjghy@2020",
            //};
            var api=new TestApi("http://hy.gxjgjt.com:10080/k3cloud/", "5f0686e0d50478", "Administrator", "gxjghy@2020");
            var list=api.GetList();
        }
    }
}
