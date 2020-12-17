using Microsoft.VisualStudio.TestTools.UnitTesting;
using MgSoft.K3Cloud.WebApi.Common.Api.Stk;
using System;
using System.Collections.Generic;
using System.Text;
using MgSoft.K3Cloud.WebApiTests;
using MgSoft.K3Cloud.WebApi.Common.Dto.Stk;
using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using MgSoft.K3Cloud.WebApi.Common.Model;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Stk.Tests
{
    [TestClass()]
    public class Stk_MisDeliveryApiTests : BaseTest
    {
        private Stk_MisDeliveryApi stk_MisDeliveryApi;
        public Stk_MisDeliveryApiTests()
        {
            stk_MisDeliveryApi = new Stk_MisDeliveryApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            stk_MisDeliveryApi.Save(GetSaveDto());
        }

        private Stk_MisDeliverySaveInputDto GetSaveDto()
        {
            return new Stk_MisDeliverySaveInputDto()
            {
                FBillNo = "测试12211",
                FBillTypeID = new FNumberProperty("QTCKD01_SYS"),
                FStockOrgId = new FNumberProperty("102"),
                FPickOrgId = new FNumberProperty("102"),
                FOwnerTypeIdHead = "Bd_Supplier",
                FCustId = new FNumberProperty("CUST0001"),
                FEntity = new List<Stk_MisDelivery_FEntity>()
                {
                    new Stk_MisDelivery_FEntity()
                    {
                        FMaterialId = new FNumberProperty("1.01.002"),
                        FUnitID = new FNumberProperty("Pcs"),
                        FQty = 20m,
                        FStockId = new FNumberProperty("CK001"),
                        FStockLocId = new StockLocModel()
                        {
                            FSTOCKLOCID__FF100001 = new FNumberProperty("001"),
                            FSTOCKLOCID__FF100002 = new FNumberProperty("001")
                        },
                        FLot = new FNumberProperty("123456"),
                        FOwnerId = new FNumberProperty("VEN00001"),

                    }
                }
            };
        }
    }
}