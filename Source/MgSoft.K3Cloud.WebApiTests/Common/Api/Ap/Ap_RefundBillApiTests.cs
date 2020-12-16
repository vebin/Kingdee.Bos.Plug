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
    public class Ap_RefundBillApiTests : BaseTest
    {
        private Ap_RefundBillApi Ap_RefundBillApi;
        public Ap_RefundBillApiTests()
        {
            Ap_RefundBillApi = new Ap_RefundBillApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            Ap_RefundBillApi.Save(GetSaveDto());
        }

        public Ap_RefundBillSaveInputDto GetSaveDto()
        {
            return new Ap_RefundBillSaveInputDto()
            {
                FCONTACTUNIT = new FNumberProperty("VEN00001"),
                FPAYUNIT = new FNumberProperty("VEN00001"),
                FPAYORGID = new FNumberProperty("102"),
                FSETTLEORGID = new FNumberProperty("102"),
                FPURCHASEORGID = new FNumberProperty("102"),
                FREFUNDBILLENTRY = new List<Ap_RefundBill_Entry>()
                {
                    new Ap_RefundBill_Entry()
                    {
                        FSETTLETYPEID = new FNumberProperty("JSFS01_SYS"),
                        FREFUNDAMOUNTFOR = 5m
                    }
                }
            };
        }
    }
}