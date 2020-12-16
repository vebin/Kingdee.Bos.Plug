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
    public class Ap_PayBillApiTests : BaseTest
    {
        private Ap_PayBillApi Ap_PayBillApi;
        public Ap_PayBillApiTests()
        {
            Ap_PayBillApi = new Ap_PayBillApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            Ap_PayBillApi.Save(GetSaveDto());
        }

        private Ap_PayBillSaveInputDto GetSaveDto()
        {
            return new Ap_PayBillSaveInputDto()
            {
                FCONTACTUNIT = new FNumberProperty("VEN00001"),
                FRECTUNIT = new FNumberProperty("VEN00001"),
                FPAYORGID = new FNumberProperty("102"),
                FSETTLEORGID = new FNumberProperty("102"),
                FPURCHASERGROUPID = new FNumberProperty("102"),
                FPAYBILLENTRY = new List<Ap_PayBill_Entry>()
                {
                    new Ap_PayBill_Entry()
                    {
                        FSETTLETYPEID = new FNumberProperty("JSFS01_SYS"),
                        FPURPOSEID = new FNumberProperty("SFKYT08_SYS"),
                        FPAYTOTALAMOUNTFOR = 3m
                    }
                }
            };
        }
    }
}