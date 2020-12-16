using Microsoft.VisualStudio.TestTools.UnitTesting;
using MgSoft.K3Cloud.WebApi.Common.Api.Ar;
using System;
using System.Collections.Generic;
using System.Text;
using MgSoft.K3Cloud.WebApiTests;
using MgSoft.K3Cloud.WebApi.Common.Dto.Ar;
using MgSoft.K3Cloud.WebApi.Common.Dto.Property;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Ar.Tests
{
    [TestClass()]
    public class Ar_ReceivableApiTests : BaseTest
    {
        private Ar_ReceivableApi Ar_ReceivableApi;
        public Ar_ReceivableApiTests()
        {
            Ar_ReceivableApi = new Ar_ReceivableApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            Ar_ReceivableApi.Save(GetSaveDto());
        }

        public Ar_ReceivableSaveInputDto GetSaveDto()
        {
            return new Ar_ReceivableSaveInputDto()
            {
                FENDDATE_H = Convert.ToDateTime("2020/11/15"),
                FCUSTOMERID = new FNumberProperty("CUST0001"),
                FSETTLEORGID = new FNumberProperty("102"),
                FPAYORGID = new FNumberProperty("102"),
                FSALEORGID = new FNumberProperty("102"),

                FEntityDetail = new List<Ar_Receivable_EntityDetail>()
                {
                    new Ar_Receivable_EntityDetail()
                    {
                        FMATERIALID = new FNumberProperty("1.01.002"),
                        FTaxPrice = 10m,
                        FPriceQty = 10m
                    }
                }
            };
        }
    }
}