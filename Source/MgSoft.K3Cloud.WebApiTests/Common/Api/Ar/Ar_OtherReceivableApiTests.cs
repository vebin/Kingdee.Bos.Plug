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
    public class Ar_OtherReceivableApiTests : BaseTest
    {
        private Ar_OtherReceivableApi Ar_OtherReceivableApi;
        public Ar_OtherReceivableApiTests()
        {
            Ar_OtherReceivableApi = new Ar_OtherReceivableApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            Ar_OtherReceivableApi.Save(GetSaveDto());
        }

        private Ar_OtherReceivableSaveInputDto GetSaveDto()
        {
            return new Ar_OtherReceivableSaveInputDto()
            {
                FCONTACTUNIT = new FNumberProperty("201701001"),
                FSETTLEORGID = new FNumberProperty("102"),
                FPAYORGID = new FNumberProperty("102"),
                FSALEORGID = new FNumberProperty("102"),

                FEntity = new List<Ar_OtherReceivable_Entry>()
                {
                    new Ar_OtherReceivable_Entry()
                    {
                        FCOSTDEPARTMENTID = new FNumberProperty("BM000003"),
                        FTAXAMOUNTFOR = 10m
                    }
                }
            };
        }
    }
}