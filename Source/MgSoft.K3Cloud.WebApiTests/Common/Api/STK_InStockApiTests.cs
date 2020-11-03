using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.Common.Utilities;
using MgSoft.K3Cloud.WebApi.Common.Dto;
using MgSoft.K3Cloud.WebApi.Dto;
using MgSoft.K3Cloud.WebApi.Common.Api.Stk;
using MgSoft.K3Cloud.WebApi.Common.Dto.Stk;
using MgSoft.K3Cloud.WebApiTests;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Tests
{
    [TestClass()]
    public class STK_InStockApiTests:BaseTest
    {
        [TestMethod()]
        public void SaveTest()
        {
            Stk_InStockApi inStockApi = new Stk_InStockApi(GetApiServerInfo());
            inStockApi.Save(getSaveDto());
        }

        private STK_InStockSaveInputDto getSaveDto()
        {
            var result = new STK_InStockSaveInputDto()
            {
                FStockOrgId = new FNumberProperty("106.2"),
                FDate = DateTime.Now,
                FBillTypeID = new FNumberProperty("RKD01_SYS"),
                FOwnerTypeIdHead = "BD_OwnerOrg",
                FOwnerIdHead = new FNumberProperty("106.2"),
                FPurchaseOrgId=new FNumberProperty("106.2"),
                FSupplierId = new FNumberProperty("VEN00001"),

                FInStockFin = new Stk_InStock_FInStockFin()
                {
                    FSettleOrgId = new FNumberProperty("100"),
                    FSettleCurrId=new FNumberProperty("PRE001"),
                    FPriceTimePoint = "1"
                },
                FInStockEntry=new List<Stk_InStock_FInStockEntry>()
                {
                    new Stk_InStock_FInStockEntry()
                    {
                        FMaterialId=new FNumberProperty("1.01"),
                        FUnitID=new FNumberProperty("100"),
                        FPriceUnitID=new FNumberProperty("1.1110001"),
                        FOWNERTYPEID="BD_OwnerOrg",
                        FOWNERID=new FNumberProperty("106.2"),
                        FRemainInStockUnitId=new FNumberProperty("100")
                    }
                }
            };

            return result;
        }
    }
}