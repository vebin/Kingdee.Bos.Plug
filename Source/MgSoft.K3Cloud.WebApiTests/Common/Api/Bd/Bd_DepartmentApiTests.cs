using Microsoft.VisualStudio.TestTools.UnitTesting;
using MgSoft.K3Cloud.WebApi.Common.Api.Bd;
using System;
using System.Collections.Generic;
using System.Text;
using MgSoft.K3Cloud.WebApiTests;
using MgSoft.K3Cloud.WebApi.Common.Dto.Bd;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Bd.Tests
{
    [TestClass()]
    public class Bd_DepartmentApiTests : BaseTest
    {
        private Bd_DepartmentApi bd_DepartmentApi;

        public Bd_DepartmentApiTests()
        {
            bd_DepartmentApi = new Bd_DepartmentApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            bd_DepartmentApi.Save(GetSaveDto());
        }

        private Bd_DepartmentSaveInputDto GetSaveDto()
        {
            return new Bd_DepartmentSaveInputDto()
            {
                FName = "测试部门1",
                FCreateOrgId = new Dto.FNumberProperty("100"),
                FUseOrgId = new Dto.FNumberProperty("100")
            };
        }
        [TestMethod]
        public void SubmitTest()
        {
            bd_DepartmentApi.Submit(new WebApi.Dto.SubmitInputDto()
            {
                Numbers = new string[] { "BM000018" }
            });
        }
    }
}