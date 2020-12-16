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
    public class Ap_OtherPayableApiTests : BaseTest
    {
        private Ap_OtherPayableApi Ap_OtherPayableApi;
        public Ap_OtherPayableApiTests()
        {
            Ap_OtherPayableApi = new Ap_OtherPayableApi(GetApiServerInfo());
        }
        [TestMethod()]
        public void SaveTest()
        {
            Ap_OtherPayableApi.Save(GetSaveDto());
        }

        private Ap_OtherPayableSaveInputDto GetSaveDto()
        {
            return new Ap_OtherPayableSaveInputDto()
            {
                FCONTACTUNIT = new FNumberProperty("201701001"),
                FSETTLEORGID = new FNumberProperty("102"),
                FPAYORGID = new FNumberProperty("102"),
                FPURCHASEORGID = new FNumberProperty("102"),

                FEntity = new List<Ap_OtherPayable_Entry>()
                {
                    new Ap_OtherPayable_Entry()
                    {
                        FCOSTDEPARTMENTID = new FNumberProperty("BM000003"),
                        FTAXAMOUNTFOR = 10m
                    }
                }
            };
        }
    }
}