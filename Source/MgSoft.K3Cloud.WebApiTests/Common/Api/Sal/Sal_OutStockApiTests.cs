using Microsoft.VisualStudio.TestTools.UnitTesting;
using MgSoft.K3Cloud.WebApi.Common.Api.Sal;
using System;
using System.Collections.Generic;
using System.Text;
using MgSoft.K3Cloud.WebApiTests;
using MgSoft.K3Cloud.WebApi.Common.Dto.Sal;
using MgSoft.K3Cloud.WebApi.Common.Dto;
using MgSoft.K3Cloud.WebApi.Dto;
using MgSoft.K3Cloud.WebApi.Common.Dto.Property;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Sal.Tests
{
    [TestClass()]
    public class Sal_OutStockApiTests : BaseTest
    {
        private Sal_OutStockApi sal_OutStockApi;

        public Sal_OutStockApiTests()
        {
            sal_OutStockApi = new Sal_OutStockApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            sal_OutStockApi.Save(GetSave());
        }

        [TestMethod()]
        public void QueryListTest()
        {
            var data = sal_OutStockApi.GetList<Sal_OutStockGetListOutputDto>(new WebApi.Dto.GetListInputDto()
            {
                FormId = "SAL_OUTSTOCK"
            });
        }
        [TestMethod()]
        public void QueryTest()
        {
            var data = sal_OutStockApi.Get<Sal_OutStockQueryOutputDto>(new GetInputDto()
            {
                FormId = "SAL_OUTSTOCK",
                Number = "XSCKD000034"
            });
        }


        private Sal_OutStockSaveInputDto GetSave()
        {
            var Result = new Sal_OutStockSaveInputDto
            {
                FDate = DateTime.Now,
                FCustomerID = new FNumberProperty("CUST0001"),
                FStockOrgId = new FNumberProperty("106.2"),

                SubHeadEntity = new Sal_OutStock_SubHeadEntity()
                {
                    FSettleOrgID = new FNumberProperty("106"),
                    FExchangeRate = 1
                },

                FEntity = new List<Sal_OutStock_FEntity<Sal_OutStock_FTaxDetailSubEntity, Sal_OutStock_FSerialSubEntity>>()
                {
                    new Sal_OutStock_FEntity<Sal_OutStock_FTaxDetailSubEntity, Sal_OutStock_FSerialSubEntity>()
                    {
                        FStockID = new FNumberProperty("Test1"),
                        FMaterialID = new FNumberProperty("1.04"),
                        FPriceUnitId = new FNumberProperty("Pcs"),
                        FPriceUnitQty = 100,

                        FTaxDetailSubEntity = new List<Sal_OutStock_FTaxDetailSubEntity>()
                        {
                            new Sal_OutStock_FTaxDetailSubEntity()
                            {
                                FTaxRate = 0
                            }
                        },

                        FSerialSubEntity = new List<Sal_OutStock_FSerialSubEntity>()
                        {
                            new Sal_OutStock_FSerialSubEntity()
                            {
                                FSerialNo = "111",
                                FSerialNote = "111"
                            }
                        }


                    }

                }
            };

            return Result;
        }
    }
}