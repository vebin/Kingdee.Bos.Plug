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
    public class Pur_MrbApiTests : BaseTest
    {
        private Pur_MrbApi Pur_MrbApi;

        public Pur_MrbApiTests()
        {
            Pur_MrbApi = new Pur_MrbApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            Pur_MrbApi.Save(GetSaveDto());
        }

        public Pur_MrbSaveInputDto GetSaveDto()
        {
            return new Pur_MrbSaveInputDto()
            {

                FDate = DateTime.Now,
                FMRTYPE = "库存退料",
                FMRMODE = "退料补料",
                FStockOrgId = new FNumberProperty("102"),
                FRequireOrgId = new FNumberProperty("102"),
                FPurchaseOrgId = new FNumberProperty("102"),
                FREPLENISHMODE = "创建补料订单",
                FSupplierID = new FNumberProperty("VEN00001"),
                FPURMRBFIN = new Pur_Mrb_FPurmrbFin()
                {
                    FSettleOrgId = new FNumberProperty("102"),
                    FSettleCurrId = new FNumberProperty("PRE001"),
                    FEXCHANGETYPEID = new FNumberProperty("HLTX01_SYS"),
                    FEXCHANGERATE = 1m
                },
                FPURMRBENTRY = new List<Pur_Mrb_FPurmrbEntry>()
                {
                    new Pur_Mrb_FPurmrbEntry()
                    {
                        FMATERIALID = new FNumberProperty("1.01.002"),
                        FUnitID = new FNumberProperty("Pcs"),
                        FRMREALQTY = 5m,
                        FPRICEUNITID = new FNumberProperty("Pcs"),
                        FSTOCKID = new FNumberProperty("CK001"),
                        FSTOCKLOCID = new Pur_Mrb_StrockLocModel()
                        {
                            FSTOCKLOCID__FF100001 = new FNumberProperty("001"),
                            FSTOCKLOCID__FF100002 = new FNumberProperty("002")
                        },
                        FCarryUnitId = new FNumberProperty("Pcs"),
                        FLot = new FNumberProperty("55555")
                    }
                }
            };
        }
    }
}