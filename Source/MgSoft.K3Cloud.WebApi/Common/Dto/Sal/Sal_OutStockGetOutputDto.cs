using MgSoft.K3Cloud.WebApi.Common.Dto.Sal.Query;
using MgSoft.K3Cloud.WebApi.Common.Model;
using MgSoft.K3Cloud.WebApi.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Sal
{
    public class Sal_OutStockGetOutputDto<Type_Entry>
        where Type_Entry : Sal_QutStockEntryGetOutputDto
    {
        [JsonProperty(PropertyName = "MultiLanguageText")]
        public MultiLanguageText[] MultiLanguageText { get; set; }
        /// <summary>
        /// 单据内码
        /// </summary>
        [JsonProperty(propertyName: ("ID"))]
        public virtual long Id { get; set; }
        /// <summary>
        /// 单据编号
        /// </summary>
        [JsonProperty(propertyName: ("BillNo"))]
        public virtual string BillNo { get; set; }
        /// <summary>
        /// 制单人
        /// </summary>
        [JsonProperty(propertyName: ("FCreatorId"))]
        public virtual UserData Creator { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        [JsonProperty(propertyName: ("FModifierId"))]
        public virtual UserData Modified { get; set; }
        /// <summary>
        /// 审核人
        /// </summary>
        [JsonProperty(propertyName: ("FApproverID"))]
        public virtual UserData Apporover { get; set; }

        /// <summary>
        /// 发货组织
        /// </summary>
        [JsonProperty(propertyName: ("StockOrgId"))]
        public virtual BaseData StockOrg { get; set; }

        /// <summary>
        /// 销售组织
        /// </summary>
        [JsonProperty(propertyName: ("SaleOrgId"))]
        public virtual BaseData SaleOrg { get; set; }
        /// <summary>
        /// 结算组织
        /// </summary>
        [JsonProperty(propertyName: ("SettleOrgID"))]
        public virtual BaseData SettleOrg { get; set; }
        /// <summary>
        /// 明细信息
        /// </summary>
        [JsonProperty(propertyName: ("SAL_OUTSTOCKENTRY"))]
        public List<Sal_QutStockEntryGetOutputDto> Entry { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        [JsonProperty(propertyName: ("Price"))]
        public virtual decimal Price { get; set; }
    }

    public class Sal_OutStockQueryOutputDto : Sal_OutStockGetOutputDto<Sal_QutStockEntryGetOutputDto>
    { }
}
