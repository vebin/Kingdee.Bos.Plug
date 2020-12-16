using Microsoft.VisualStudio.TestTools.UnitTesting;
using MgSoft.K3Cloud.WebApi.Common.Api.Bd;
using System;
using System.Collections.Generic;
using System.Text;
using MgSoft.K3Cloud.WebApiTests;
using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using MgSoft.K3Cloud.WebApi.Common.Dto.Bd;
using MgSoft.K3Cloud.WebApi.Dto;

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
                FCreateOrgId = new FNumberProperty("100"),
                FUseOrgId = new FNumberProperty("100"),
                FStaffNumber = "Test1",
                FPostEntity = new List<Bd_Empinfo_PostEntity>()
                {
                    new Bd_Empinfo_PostEntity()
                    {
                        FPost = new FNumberProperty("Test1"),
                        FPostDept = new FNumberProperty("BM000019"),
                        FWorkOrgId = new FNumberProperty("106.2")
                    }
                }
            };
        }
        [TestMethod()]
        public void SubmitTest()
        {
            bd_EmpinfoApi.Submit(new SubmitInputDto()
            {
                Numbers = new string[] { "Test1" }
            });
        }
    }
}