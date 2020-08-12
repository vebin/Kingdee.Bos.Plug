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
            var api=new TestApi("http://win-npgu7b2g150/K3Cloud/", "5edf5498bbbe2c", "Administrator","888888");
            var list=api.GetList();
        }
    }
}
