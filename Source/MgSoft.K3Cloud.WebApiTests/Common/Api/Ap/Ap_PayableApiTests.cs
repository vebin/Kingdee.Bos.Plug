using Microsoft.VisualStudio.TestTools.UnitTesting;
using MgSoft.K3Cloud.WebApi.Common.Api.Ap;
using System;
using System.Collections.Generic;
using System.Text;
using MgSoft.K3Cloud.WebApiTests;
using MgSoft.K3Cloud.WebApi.Common.Dto.Ap;
using MgSoft.K3Cloud.WebApi.Common.Dto.Property;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Ap.Tests
{
    [TestClass()]
    public class Ap_PayableApiTests : BaseTest
    {
        private Ap_PayableApi Ap_PayableApi;
        public Ap_PayableApiTests()
        {
            Ap_PayableApi = new Ap_PayableApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            Ap_PayableApi.Save(GetSaveDto());
        }

        public Ap_PayableSaveInputDto GetSaveDto()
        {
            return new Ap_PayableSaveInputDto()
            {
                FSUPPLIERID = new FNumberProperty("VEN00001"),
                FSETTLEORGID = new FNumberProperty("102"),
                FPAYORGID = new FNumberProperty("102"),
                FPURCHASEORGID = new FNumberProperty("102"),
                FEntityDetail = new List<Ap_Payable_EntryDetail>()
                {
                    new Ap_Payable_EntryDetail()
                    {
                        FMATERIALID = new FNumberProperty("1.01.002"),
                        FPriceQty = 50m,
                        FTaxPrice = 5m
                    }
                }
            };
        }
    }
}