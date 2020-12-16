using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
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
        public virtual long? FVOUCHERID { get; set; }
        [JsonRequired]
        public virtual FNumberProperty FAccountBookID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FBUSDATE { get; set; }
        /// <summary>
        /// 凭证字
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FVOUCHERGROUPID { get; set; }
        /// <summary>
        /// 凭证号
        /// </summary>
        [JsonRequired]
        public virtual string FVOUCHERGROUPNO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal FATTACHMENTS { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool FISADJUSTVOUCHER { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FDocumentStatus { get; set; }
        /// <summary>
        /// 会计年度（必填项）
        /// </summary>
        [JsonRequired]
        public virtual decimal? FYEAR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSourceBillKey { get; set; }
        /// <summary>
        /// 期间（必填项）
        /// </summary>
        [JsonRequired]
        public virtual decimal FPERIOD { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FIMPORTVERSION { get; set; }
        /// <summary>
        /// 核算组织
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FACCBOOKORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Gl_Voucher_FEntity> FEntity { get; set; }

    }
    public class Gl_VoucherSaveInputDto : Gl_VoucherSaveInputDto<Gl_Voucher_FEntity>
    { }
}
