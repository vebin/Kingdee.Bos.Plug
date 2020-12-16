using Microsoft.VisualStudio.TestTools.UnitTesting;
using MgSoft.K3Cloud.WebApi.Common.Api.Stk;
using System;
using System.Collections.Generic;
using System.Text;
using MgSoft.K3Cloud.WebApiTests;
using MgSoft.K3Cloud.WebApi.Common.Dto.Stk;
using MgSoft.K3Cloud.WebApi.Common.Dto.Property;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Stk.Tests
{
    [TestClass()]
    public class Stk_MiscellaneousApiTests : BaseTest
    {
        private Stk_MiscellaneousApi stk_MiscellaneousApi;

        public Stk_MiscellaneousApiTests()
        {
            stk_MiscellaneousApi = new Stk_MiscellaneousApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            stk_MiscellaneousApi.Save(GetSaveDto());
        }

        private Stk_MiscellaneousSaveInputDto GetSaveDto()
        {
            return new Stk_MiscellaneousSaveInputDto()
            {
                FStockOrgId = new FNumberProperty("102"),
                FStockDirect = "普通",
                FDate = DateTime.Now,
                FOwnerTypeIdHead = "Bd_Supplier",
                FSUPPLIERID = new FNumberProperty("VEN00001"),
                FEntity = new List<Stk_Miscellaneous_FEntity>()
                {
                    new Stk_Miscellaneous_FEntity()
                    {
                        FMATERIALID = new FNumberProperty("1.01.002"),
                        FUnitID = new FNumberProperty("Pcs"),
                        FSTOCKID = new FNumberProperty("CK002"),
                        FQty = 30m,
                        FOWNERID = new FNumberProperty("VEN00001"),
                        FLOT = new FNumberProperty("22333"),
                    }
                }
            };
        }
    }
}