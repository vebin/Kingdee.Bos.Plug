using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Bd
{
    public class Bd_SupplierSaveInputDto<
        Type_Bd_Supplier_BankInfo, 
        Type_Bd_Supplier_LocationInfo,
        Type_Bd_Supplier_SupplierContact>
        where Type_Bd_Supplier_BankInfo : Bd_Supplier_BankInfo
        where Type_Bd_Supplier_LocationInfo : Bd_Supplier_LocationInfo
        where Type_Bd_Supplier_SupplierContact : Bd_Supplier_SupplierContact
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FSupplierId { get; set; }
        /// <summary>
        /// 必填项
        /// </summary>
        public FNumberProperty FCreateOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FNumber { get; set; }
        /// <summary>
        /// 必填项
        /// </summary>
        public FNumberProperty FUseOrgId { get; set; }
        /// <summary>
        /// 必填项
        /// </summary>
        public string FName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FShortName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FGroup { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCorrespondOrgId { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FDescription { get; set; }
        //"FForbiderId": {
        //    "FUserID": ""       
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FForbidDate { get; set; }
        /// <summary>
        /// 基本信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Bd_Supplier_BaseInfo FBaseInfo { get; set; }
        /// <summary>
        /// 商务信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Bd_Supplier_BusinessInfo FBusinessInfo { get; set; }
        /// <summary>
        /// 财务信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Bd_Supplier_FinanceInfo FFinanceInfo { get; set; }
        /// <summary>
        /// 银行信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Bd_Supplier_BankInfo> FBankInfo { get; set; }
        /// <summary>
        /// 组织信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Bd_Supplier_LocationInfo> FLocationInfo { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Bd_Supplier_SupplierContact> FSupplierContacts { get; set; }
    }
    public class Bd_SupplierSaveInputDto : Bd_SupplierSaveInputDto<
        Bd_Supplier_BankInfo,
        Bd_Supplier_LocationInfo, 
        Bd_Supplier_SupplierContact> 
    { }
}
