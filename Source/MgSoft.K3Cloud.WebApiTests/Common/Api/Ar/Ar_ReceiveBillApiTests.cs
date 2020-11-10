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
    public class Ar_ReceiveBillApiTests : BaseTest
    {
        private Ar_ReceiveBillApi Ar_ReceiveBillApi;
        public Ar_ReceiveBillApiTests()
        {
            Ar_ReceiveBillApi = new Ar_ReceiveBillApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            Ar_ReceiveBillApi.Save(GetSaveDto());
        }

        public Ar_ReceiveBillSaveInputDto GetSaveDto()
        {
            return new Ar_ReceiveBillSaveInputDto()
            {
                FCONTACTUNIT = new FNumberProperty("CUST0001"),
                FPAYUNIT = new FNumberProperty("CUST0001"),
                FCURRENCYID = new FNumberProperty("PRE001"),
                FPAYORGID = new FNumberProperty("102"),
                FSETTLEORGID = new FNumberProperty("102"),
                FSALEORGID = new FNumberProperty("102"),
                FSETTLECUR = new FNumberProperty("PRE001"),
                FRECEIVEBILLENTRY = new List<Ar_ReceiveBill_Entry>()
                {
                    new Ar_ReceiveBill_Entry()
                    {
                      FSETTLETYPEID = new FNumberProperty("JSFS01_SYS"),
                      FPURPOSEID = new FNumberProperty("SFKYT01_SYS"),
                      FRECTOTALAMOUNTFOR = 10m
                    },
                }
            };
        }
    }
}