using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Pur
{
    /// <summary>
    /// 采购合同保存InputDto
    /// </summary>
    /// <typeparam name="Type_Pur_Constract_ContractFin"></typeparam>
    /// <typeparam name="Type_Pur_Constract_ContractClause"></typeparam>
    /// <typeparam name="Type_Pur_Constract_ContractEntry"></typeparam>
    /// <typeparam name="Type_Pur_Constract_PayPlanEntry"></typeparam>
    public class Pur_ConstractSaveInputDto<Type_Pur_Constract_ContractFin, 
        Type_Pur_Constract_ContractClause,
        Type_Pur_Constract_ContractEntry,
        Type_Pur_Constract_PayPlanEntry> 
        where Type_Pur_Constract_ContractFin : Pur_Constract_ContractFin
        where Type_Pur_Constract_ContractClause : Pur_Constract_ContractClause
        where Type_Pur_Constract_ContractEntry : Pur_Constract_ContractEntry
        where Type_Pur_Constract_PayPlanEntry : Pur_Constract_PayPlanEntry
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBillTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCorrespondOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBillNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FEndDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FBeginDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSupplierId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPurchaseOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPurchaseDeptId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPurchaserGroupId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPurchaserId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FProviderId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FProviderAddress { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSettleId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FChargeId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCONTRACTNAME { get; set; }
        //"FProviderContactId": {"FCONTACTNUMBER": ""},
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISINPUTDETAIL { get; set; }
        /// <summary>
        /// 财务信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Pur_Constract_ContractFin FContractFin { get; set; }
        /// <summary>
        /// 合同条款
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Pur_Constract_ContractClause> FContractClause { get; set; }
        /// <summary>
        /// 明细信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Pur_Constract_ContractEntry> FContractEntry { get; set; }
        /// <summary>
        /// 付款计划
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Pur_Constract_PayPlanEntry> FPayPlanEntry { get; set; }
    }
    /// <summary>
    /// 采购合同保存InputDto
    /// </summary>
    public class Pur_ConstractSaveInputDto : Pur_ConstractSaveInputDto<Pur_Constract_ContractFin,
        Pur_Constract_ContractClause,
        Pur_Constract_ContractEntry,
        Pur_Constract_PayPlanEntry>
    { }
}
