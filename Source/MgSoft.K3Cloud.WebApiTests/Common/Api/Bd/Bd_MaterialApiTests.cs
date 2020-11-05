using Microsoft.VisualStudio.TestTools.UnitTesting;
using MgSoft.K3Cloud.WebApi.Common.Api.Bd;
using System;
using System.Collections.Generic;
using System.Text;
using MgSoft.K3Cloud.WebApiTests;
using MgSoft.K3Cloud.WebApi.Dto;
using MgSoft.K3Cloud.WebApi.Common.Dto;
using MgSoft.K3Cloud.WebApi.Common.Dto.Bd;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Bd.Tests
{
    [TestClass()]
    public class Bd_MaterialApiTests:BaseTest
    {
        private Bd_MaterialApi bd_MaterialApi;

        public Bd_MaterialApiTests()
        {
            bd_MaterialApi = new Bd_MaterialApi(GetApiServerInfo());
        }

        [TestMethod()]
        public void SaveTest()
        {
            bd_MaterialApi.Save(getSaveDto());
        }

        [TestMethod]
        public void SubmitTest()
        {
            bd_MaterialApi.Submit(new SubmitInputDto() 
            {
                Numbers=new string[]{ "TestMaterial" }
            });
        }

        private Bd_MaterialSaveInputDto getSaveDto()
        {
            return new Bd_MaterialSaveInputDto()
            {
                FName = "测试",
                FNumber="TestMaterial",
                FCreateOrgId = new FNumberProperty("100"),
                FUseOrgId=new FNumberProperty("100"),
                //FCodeType_CMK
                //FUnitId_CMK
                //SubHeadEntity=new Bd_Material_SubHeadEntity()
                //{
                //    FErpClsID = "1",
                //    FBaseUnitId = new FNumberProperty("Pcs"),
                //    FCategoryID=new FNumberProperty("CHLB01_SYS"),
                //    FFeatureItem="FFeatureItem"
                //},
                //SubHeadEntity1=new Bd_Material_SubHeadEntity1()
                //{
                //    FStoreUnitID=new FNumberProperty("Pcs"),
                //    FCurrencyId=new FNumberProperty("PRE001"),
                //    FUnitConvertDir="1",
                //    FSNGenerateTime="1",
                //    FSNManageType="1"
                //}
            };
        }
    }
}