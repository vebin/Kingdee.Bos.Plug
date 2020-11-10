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
    public class Ar_RefundBillApiTests : BaseTest
    {
        private Ar_RefundBillApi Ar_RefundApi;
        public Ar_RefundBillApiTests()
        {
            Ar_RefundApi = new Ar_RefundBillApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            Ar_RefundApi.Save(GetSaveDto());
        }

        public Ar_RefundSaveInputDtp GetSaveDto()
        {
            return new Ar_RefundSaveInputDtp()
            {
                FCONTACTUNIT = new FNumberProperty("CUST0001"),
                FRECTUNIT = new FNumberProperty("CUST0001"),
                FPAYORGID = new FNumberProperty("102"),
                FSETTLEORGID = new FNumberProperty("102"),
                FSALEORGID = new FNumberProperty("102"),
                FREFUNDBILLENTRY = new List<Ar_RefundBill_Entry>()
                {
                    new Ar_RefundBill_Entry()
                    {
                        FSETTLETYPEID = new FNumberProperty("JSFS01_SYS"),
                        FNOTE = "1111",
                        FREFUNDAMOUNTFOR = 2m
                    }
                }
            };
        }
    }
}