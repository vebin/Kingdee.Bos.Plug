using Microsoft.VisualStudio.TestTools.UnitTesting;
using MgSoft.K3Cloud.WebApi;
using System;
using System.Collections.Generic;
using System.Text;
using MgSoft.K3Cloud.WebApiTests;

namespace MgSoft.K3Cloud.WebApi.Tests
{
    [TestClass()]
    public class K3CloudDataCenterApiTests : BaseTest
    {
        [TestMethod()]
        public void GetDataCenterTest()
        {
            K3CloudDataCenterApi k3CloudDataCenterApi = new K3CloudDataCenterApi(GetApiServerInfo());
            var result = k3CloudDataCenterApi.GetDataCenter();
        }
    }
}