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
            var api=new TestApi("http://hy.gxjgjt.com:10080/k3cloud/", "5edf5498bbbe2c", "Administrator", "gxjghy@2020");
            var list=api.GetList();
        }
    }
}
