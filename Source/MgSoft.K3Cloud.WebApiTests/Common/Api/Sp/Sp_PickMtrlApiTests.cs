using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using MgSoft.K3Cloud.WebApi.Common.Dto.Sp;
using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using MgSoft.K3Cloud.WebApiTests;
using MgSoft.K3Cloud.WebApi.Common.Model;
using MgSoft.K3Cloud.WebApi.Dto;
using MgSoft.K3Cloud.WebApi.Common.Api.Sp;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Sp.Tests
{
    [TestClass()]
    public class Sp_PickMtrlApiTests : BaseTest
    {
        private Sp_PickMtrlApi sp_PickMtrlApi;
        public Sp_PickMtrlApiTests()
        {
            sp_PickMtrlApi = new Sp_PickMtrlApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            sp_PickMtrlApi.Save(GetSaveDto());
        }

        private Sp_PickMtrlSaveInputDto GetSaveDto()
        {
            return new Sp_PickMtrlSaveInputDto()
            {
                FBillNo = "测试22222",
                FStockOrgId = new FNumberProperty("102"),
                FPrdOrgId = new FNumberProperty("102"),
                FOwnerTypeId0 = "Bd_Supplier",
                FWorkShopId = new FNumberProperty("BM000003"),
                FEntity = new List<Sp_PickMtrl_FEntity>()
                {
                    new Sp_PickMtrl_FEntity()
                    {
                        FMaterialId = new FNumberProperty("1.01.002"),
                        FUnitID = new FNumberProperty("Pcs"),
                        FAppQty = 20m,
                        FActualQty = 10m,
                        FStockId = new FNumberProperty("CK001"),
                        FStockLocId = new StockLocModel()
                        {
                          FSTOCKLOCID__FF100001 = new FNumberProperty("001"),
                          FSTOCKLOCID__FF100002 = new FNumberProperty("001"),
                        },
                        FOwnerId = new FNumberProperty("VEN00001"),
                        FLot = new FNumberProperty("1111222"),
                    }
                }
            };
        }
    }
}