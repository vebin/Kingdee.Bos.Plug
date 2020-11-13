using Microsoft.VisualStudio.TestTools.UnitTesting;
using MgSoft.K3Cloud.WebApi.Common.Api.Sal;
using System;
using System.Collections.Generic;
using System.Text;
using MgSoft.K3Cloud.WebApiTests;
using MgSoft.K3Cloud.WebApi.Common.Dto.Sal;
using MgSoft.K3Cloud.WebApi.Common.Dto.Property;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Sal.Tests
{
    [TestClass()]
    public class Sal_SaleOrderApiTests : BaseTest
    {
        private Sal_SaleOrderApi Sal_SaleOrderApi;
        public Sal_SaleOrderApiTests()
        {
            Sal_SaleOrderApi = new Sal_SaleOrderApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            Sal_SaleOrderApi.Save(GetSaveDto());
        }

        private Sal_SaleOrderSaveInputDto GetSaveDto()
        {
            return new Sal_SaleOrderSaveInputDto()
            {
                FSaleOrgId = new FNumberProperty("103"),
                FCustId = new FNumberProperty("CUST0001"),
                FSaleDeptId = new FNumberProperty("BM000010"),
                FSaleGroupId = new FNumberProperty("ZXKH01"),
                FSalerId = new FNumberProperty("201801017"),

                FSaleOrderEntry = new List<Sal_SaleOrder_Entry>()
                {
                    new Sal_SaleOrder_Entry()
                    {
                        FMaterialId = new FNumberProperty("1.01"),
                        FQty = 10m
                    }
                }
            };
        }
    }
}