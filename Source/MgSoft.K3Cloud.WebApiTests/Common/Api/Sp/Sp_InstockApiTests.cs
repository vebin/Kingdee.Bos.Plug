using Microsoft.VisualStudio.TestTools.UnitTesting;
using MgSoft.K3Cloud.WebApi.Common.Api.Sp;
using System;
using System.Collections.Generic;
using System.Text;
using MgSoft.K3Cloud.WebApi.Common.Dto.Sp;
using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using MgSoft.K3Cloud.WebApiTests;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Sp.Tests
{
    [TestClass()]
    public class Sp_InstockApiTests : BaseTest
    {
        private Sp_InstockApi sp_InstockApi;

        public Sp_InstockApiTests()
        {
            sp_InstockApi = new Sp_InstockApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            sp_InstockApi.Save(GetSaveDto());
        }

        private Sp_InstockSaveInputDto GetSaveDto()
        {
            return new Sp_InstockSaveInputDto()
            {
                FBillNo = "测试11111",
                FStockOrgId = new FNumberProperty("102"),
                FPrdOrgId = new FNumberProperty("102"),
                FOwnerId0 = new FNumberProperty("102"),
                FEntity = new List<Sp_Instock_FEntity>()
                {
                    new Sp_Instock_FEntity()
                    {
                        FMaterialId = new FNumberProperty("1.01.002.0001"),
                        FInStockType = "合格品入库",
                        FUnitID = new FNumberProperty("Pcs"),
                        FRealQty = 99m,
                        FStockId = new FNumberProperty("CK001"),
                        FStockLocId = new Model.StockLocModel()
                        { 
                            FSTOCKLOCID__FF100001 = new FNumberProperty("001"),
                            FSTOCKLOCID__FF100002 = new FNumberProperty("001"),
                        },
                        FWorkShopId1 = new FNumberProperty("BM000003"),
                    }
                }
            };
        }
    }
}