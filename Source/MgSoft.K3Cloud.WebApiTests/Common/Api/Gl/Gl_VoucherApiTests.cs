using Microsoft.VisualStudio.TestTools.UnitTesting;
using MgSoft.K3Cloud.WebApi.Common.Api.Gl;
using System;
using System.Collections.Generic;
using System.Text;
using MgSoft.K3Cloud.WebApiTests;
using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using MgSoft.K3Cloud.WebApi.Common.Dto.Gl;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Gl.Tests
{
    [TestClass()]
    public class Gl_VoucherApiTests : BaseTest
    {
        private Gl_VoucherApi Gl_VoucherApi;

        public Gl_VoucherApiTests()
        {
            Gl_VoucherApi = new Gl_VoucherApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            Gl_VoucherApi.Save(GetSaveDto());
        }

        private Gl_VoucherSaveInputDto GetSaveDto()
        {
            return new Gl_VoucherSaveInputDto()
            {
                FDate = Convert.ToDateTime("2018/2/28"),
                FAccountBookID = new FNumberProperty("003"),
                FACCBOOKORGID = new FNumberProperty("102"),
                FVOUCHERGROUPID = new FNumberProperty("PRE001"),
                FVOUCHERGROUPNO = "1",
                FYEAR = 2018,
                FPERIOD = 2,
                FEntity = new List<Gl_Voucher_FEntity>()
                {
                    new Gl_Voucher_FEntity()
                    {
                        FEXPLANATION = "1",
                        FACCOUNTID = new FNumberProperty("1001"),
                        FCURRENCYID = new FNumberProperty("PRE001"),
                        FEXCHANGERATETYPE = new FNumberProperty("HLTX01_SYS"),
                        FAMOUNTFOR = 10,
                        FDEBIT = 10
                    },
                    new Gl_Voucher_FEntity()
                    {
                        FEXPLANATION = "1",
                        FACCOUNTID = new FNumberProperty("1002"),
                        FCURRENCYID = new FNumberProperty("PRE001"),
                        FEXCHANGERATETYPE = new FNumberProperty("HLTX01_SYS"),
                        FAMOUNTFOR = 10,
                        FCREDIT = 10
                    }
                }
            };
        }
    }
}