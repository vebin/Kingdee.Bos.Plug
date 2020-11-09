using MgSoft.K3Cloud.WebApi.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal
{
    public class Sal_OutStockQueryListOutputDto
    {
        /// <summary>
        /// 单据内码
        /// </summary>
        [JsonProperty(propertyName: ("FID"))]
        public virtual long Id { get; set; }
        /// <summary>
        /// 单据编号
        /// </summary>
        [JsonProperty(propertyName: ("FBillNo"))]
        public virtual string BillNo { get; set; }
        /// <summary>
        /// 制单人
        /// </summary>
        [JsonProperty(propertyName: ("FCreatorId.FName"))]
        public virtual string Creator { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        [JsonProperty(propertyName: ("FModifierId.FName"))]
        public virtual string Modified { get; set; }
        /// <summary>
        /// 审核人
        /// </summary>
        [JsonProperty(propertyName: ("FApproverID.FName"))]
        public virtual string Apporover { get; set; }

        /// <summary>
        /// 发货组织
        /// </summary>
        [JsonProperty(propertyName: ("FStockOrgId.FName"))]
        public virtual string StockOrg { get; set; }

        /// <summary>
        /// 销售组织
        /// </summary>
        [JsonProperty(propertyName: ("FSaleOrgId.FName"))]
        public virtual string SaleOrg { get; set; }
        /// <summary>
        /// 结算组织
        /// </summary>
        [JsonProperty(propertyName: ("FSettleOrgID.FName"))]
        public virtual string SettleOrg { get; set; }
        /// <summary>
        /// 物料编码
        /// </summary>
        [JsonProperty(propertyName:("FMaterialID.FNumber"))]
        public virtual string MaterialNumber { get; set; }
        /// <summary>
        /// 物料名称
        /// </summary>
        [JsonProperty(propertyName: ("FMaterialID.FName"))]
        public virtual string MaterialName { get; set; }
        /// <summary>
        /// 物料规格型号
        /// </summary>
        [JsonProperty(propertyName: ("FMaterialID.FSpecification"))]
        public virtual string MaterialSpecifications { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        [JsonProperty(propertyName:("FPrice"))]
        public virtual decimal Price { get; set; }
    }
}
