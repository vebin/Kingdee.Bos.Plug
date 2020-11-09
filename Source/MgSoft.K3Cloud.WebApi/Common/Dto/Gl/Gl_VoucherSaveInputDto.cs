using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Gl
{
    /// <summary>
    /// 凭证
    /// </summary>
    /// <typeparam name="Type_Gl_Voucher_FEntity"></typeparam>
    public class Gl_VoucherSaveInputDto<Type_Gl_Voucher_FEntity> 
        where Type_Gl_Voucher_FEntity : Gl_Voucher_FEntity
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FVOUCHERID { get; set; }
        [JsonRequired]
        public FNumberProperty FAccountBookID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FBUSDATE { get; set; }
        /// <summary>
        /// 凭证字
        /// </summary>
        [JsonRequired]
        public FNumberProperty FVOUCHERGROUPID { get; set; }
        /// <summary>
        /// 凭证号
        /// </summary>
        [JsonRequired]
        public string FVOUCHERGROUPNO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal FATTACHMENTS { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool FISADJUSTVOUCHER { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FDocumentStatus { get; set; }
        /// <summary>
        /// 会计年度（必填项）
        /// </summary>
        [JsonRequired]
        public decimal? FYEAR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSourceBillKey { get; set; }
        /// <summary>
        /// 期间（必填项）
        /// </summary>
        [JsonRequired]
        public decimal FPERIOD { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FIMPORTVERSION { get; set; }
        /// <summary>
        /// 核算组织
        /// </summary>
        [JsonRequired]
        public FNumberProperty FACCBOOKORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Gl_Voucher_FEntity> FEntity { get; set; }

    }
    public class Gl_VoucherSaveInputDto : Gl_VoucherSaveInputDto<Gl_Voucher_FEntity>
    { }
}
