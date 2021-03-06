﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MgSoft.K3Cloud.WebApi.Common.Api.Bd;
using System;
using System.Collections.Generic;
using System.Text;
using MgSoft.K3Cloud.WebApiTests;
using Newtonsoft.Json;
using MgSoft.K3Cloud.WebApi.Dto;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
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
                FCreateOrgId = new FNumberProperty("100"),
                FUseOrgId = new FNumberProperty("100")
            };
        }
        [TestMethod]
        public void SubmitTest()
        {
            bd_DepartmentApi.Submit(new SubmitInputDto()
            {
                Numbers = new string[] { "BM000018" }
            });
        }

        [TestMethod]
        public void Get()
        {
            var data = bd_DepartmentApi.Get<Bd_DepartmetQueryOutputDto>(new GetInputDto()
            {
                FormId = "BD_Department",
                Number =  "BM000018" 
            });
        }

        [TestMethod]
        public void GetList()
        {
            var data = bd_DepartmentApi.GetList<Bd_DepartmentQueryListOutputDto>(new GetListInputDto()
            {
                FormId = "Bd_Department"
            });
            var data2 = JsonConvert.SerializeObject(data);
        }


        [TestMethod]
        public void DeleteTest()
        {
            bd_DepartmentApi.Delete(new DeleteInputDto()
            {
                FormId = "Bd_Department",
                Numbers = new string[] { "VEN00016" }
            });
        }
    }
}