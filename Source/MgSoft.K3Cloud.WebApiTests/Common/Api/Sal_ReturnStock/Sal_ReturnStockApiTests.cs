﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MgSoft.K3Cloud.WebApi.Common.Api.Sal_ReturnStock;
using System;
using System.Collections.Generic;
using System.Text;
using MgSoft.K3Cloud.WebApiTests;
using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using MgSoft.K3Cloud.WebApi.Common.Dto.Sal_ReturnStock;
using MgSoft.K3Cloud.WebApi.Common.Dto.Sal;
using MgSoft.K3Cloud.WebApi.Common.Model;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Sal_ReturnStock.Tests
{
    [TestClass()]
    public class Sal_ReturnStockApiTests : BaseTest
    {
        private Sal_ReturnStockApi Sal_ReturnStockApi;
        public Sal_ReturnStockApiTests()
        {
            Sal_ReturnStockApi = new Sal_ReturnStockApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            Sal_ReturnStockApi.Save(GetSaveDTO());
        }

        private Sal_ReturnStockSaveInputDto GetSaveDTO()
        {
            return new Sal_ReturnStockSaveInputDto()
            {
                FSaleOrgId = new FNumberProperty("102"),
                FStockOrgId = new FNumberProperty("102"),                
                FRetcustId = new FNumberProperty("CUST0001"),
                SubHeadEntity = new Sal_ReturnStock_SubHeadEntity()
                {
                    FSettleCurrId = new FNumberProperty("PRE001"),
                    FSettleOrgId = new FNumberProperty("102"),
                    FExchangeRate = 1
                },
                FEntity = new List<Sal_ReturnStock_FEntity>()
                {
                    new Sal_ReturnStock_FEntity()
                    {
                        FMaterialId = new FNumberProperty("1.01.002"),
                        FRealQty = 5m,
                        FUnitID = new FNumberProperty("Pcs"),
                        FStockId = new FNumberProperty("CK001"),
                        FStockstatusId = new FNumberProperty("KCZT01_SYS"),
                        FReturnType = new FNumberProperty("THLX01_SYS"),
                        FLot = new FNumberProperty("123456"),
                        FStocklocId = new StockLocModel()
                        {
                            FSTOCKLOCID__FF100001 = new FNumberProperty("001"),
                            FSTOCKLOCID__FF100002= new FNumberProperty("001"),
                        },
                        FSalUnitQty = 5
                    },
                    new Sal_ReturnStock_FEntity()
                    {
                        FMaterialId = new FNumberProperty("1.01.002.0001"),
                        FRealQty = 10m,
                        FUnitID = new FNumberProperty("Pcs"),
                        FStockId = new FNumberProperty("CK001"),
                        FStockstatusId = new FNumberProperty("KCZT01_SYS"),
                        FReturnType = new FNumberProperty("THLX01_SYS"),
                        FStocklocId = new StockLocModel()
                        {
                            FSTOCKLOCID__FF100001 = new FNumberProperty("001"),
                            FSTOCKLOCID__FF100002= new FNumberProperty("001"),
                        },
                        FSalUnitQty = 5
                    }
                }
            };
        }
    }
}