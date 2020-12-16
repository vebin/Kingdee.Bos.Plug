using Microsoft.VisualStudio.TestTools.UnitTesting;
using MgSoft.K3Cloud.WebApi.Common.Api.Pur;
using System;
using System.Collections.Generic;
using System.Text;
using MgSoft.K3Cloud.WebApiTests;
using MgSoft.K3Cloud.WebApi.Common.Dto.Pur;
using MgSoft.K3Cloud.WebApi.Common.Dto.Property;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Pur.Tests
{
    [TestClass()]
    public class Pur_PurchaseOrderApiTests : BaseTest
    {
        public Pur_PurchaseOrderApi Pur_PurchaseOrderApi;
        public Pur_PurchaseOrderApiTests()
        {
            Pur_PurchaseOrderApi = new Pur_PurchaseOrderApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            Pur_PurchaseOrderApi.Save(GetSaveDto());
        }

        public Pur_PurchaseOrderSaveInputDto GetSaveDto()
        {
            return new Pur_PurchaseOrderSaveInputDto()
            {
                FSupplierId = new FNumberProperty("VEN00002"),
                FPOOrderFinance = new Pur_PurchaseOrder_Finace()
                {
                    FExchangeTypeId = new FNumberProperty("HLTX01_SYS"),
                },
                FPOOrderEntry = new List<Pur_PurchaseOrder_Entry>()
                {
                    new Pur_PurchaseOrder_Entry()
                    {
                        FMaterialId = new FNumberProperty("1.01.002.0001"),
                        FQty = 2m,
                        FTaxPrice = 2m
                    }
                }
            };
        }
    }
}