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
    public class Bd_EmpinfoApiTests : BaseTest
    {
        private Bd_EmpinfoApi bd_EmpinfoApi;

        public Bd_EmpinfoApiTests()
        {
            bd_EmpinfoApi = new Bd_EmpinfoApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            bd_EmpinfoApi.Save(GetSaveDto());
        }

        private Bd_EmpinfoSaveInputDto GetSaveDto()
        {
            return new Bd_EmpinfoSaveInputDto()
            {
                FName = "Api测试员工",
                FCreateOrgId = new Dto.FNumberProperty("100"),
                FUseOrgId = new Dto.FNumberProperty("100"),
                FStaffNumber = "Test1",
                FPostEntity = new List<Bd_Empinfo_PostEntity>()
                {
                    new Bd_Empinfo_PostEntity()
                    {
                        FPost = new Dto.FNumberProperty("Test1"),
                        FPostDept = new Dto.FNumberProperty("BM000019"),
                        FWorkOrgId = new Dto.FNumberProperty("106.2")
                    }
                }
            };
        }
        [TestMethod()]
        public void SubmitTest()
        {
            bd_EmpinfoApi.Submit(new WebApi.Dto.SubmitInputDto()
            {
                Numbers = new string[] { "Test1" }
            });
        }
    }
}