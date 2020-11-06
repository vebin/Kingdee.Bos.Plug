using Microsoft.VisualStudio.TestTools.UnitTesting;
using MgSoft.K3Cloud.WebApi.Common.Api.Bd;
using System;
using System.Collections.Generic;
using System.Text;
using MgSoft.K3Cloud.WebApiTests;
using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using MgSoft.K3Cloud.WebApi.Common.Dto.Bd;
using MgSoft.K3Cloud.WebApi.Common.Dto;
using MgSoft.K3Cloud.WebApi.Dto;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Bd.Tests
{
    [TestClass()]
    public class Bd_SupplierApiTests : BaseTest
    {
        private Bd_SupplierApi Bd_SupplierApi;

        public Bd_SupplierApiTests()
        {
            Bd_SupplierApi = new Bd_SupplierApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            Bd_SupplierApi.Save(GetSaveDto());
        }

        private Bd_SupplierSaveInputDto GetSaveDto()
        {
            return new Bd_SupplierSaveInputDto()
            {
                FName = "Api测试供应商1",
                FCreateOrgId = new FNumberProperty("100"),
                FUseOrgId = new FNumberProperty("100"),
                FFinanceInfo = new Bd_Supplier_FinanceInfo()
                {
                    FPayCurrencyId = new FNumberProperty("PRE001")
                },
                FLocationInfo = new List<Bd_Supplier_LocationInfo>()
                {
                  new Bd_Supplier_LocationInfo()
                  {
                      FLocName = "供应商测试地址",
                      FLocAddress = "供应商测试地址",
                      FLocMobile = "供应商测试手机",
                      FLocNewContact = new FNumberProperty("Test1")
                  }
                }
            };
        }

        [TestMethod]
        public void SubmitTest()
        {
            Bd_SupplierApi.Submit(new SubmitInputDto()
            {
                Numbers = new string[] { "VEN00014" }
            });
        }
    }
}