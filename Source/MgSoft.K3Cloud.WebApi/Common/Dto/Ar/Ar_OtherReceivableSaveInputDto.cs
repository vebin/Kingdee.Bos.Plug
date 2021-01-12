using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ar
{
    /// <summary>
    /// 其他应收单Api
    /// </summary>
    public class Ar_OtherReceivableSaveInputDto<Type_Ar_OtherReceivable_Entry>
        where Type_Ar_OtherReceivable_Entry : Ar_OtherReceivable_Entry
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FID{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FBillTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FBillNo{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FDATE{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FENDDATE_H{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISINIT { get; set; }
        /// <summary>
        /// 往来单位类型
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FCONTACTUNITTYPE{ get; set; }
        /// <summary>
        /// 往来单位(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCONTACTUNIT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FAMOUNTFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCURRENCYID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FDEPARTMENTID { get; set; }
        /// <summary>
        /// 结算组织(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSETTLEORGID { get; set; }
        /// <summary>
        /// 收款组织(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPAYORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSALEDEPTID { get; set; }
        /// <summary>
        /// 销售组织(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSALEORGID{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSALEGROUPID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSALEERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FACCNTTIMEJUDGETIME{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSettleTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FMAINBOOKSTDCURRID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FEXCHANGETYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FExchangeRate{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FNOTAXAMOUNT{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FTAXAMOUNT{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FCancelStatus{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FAR_OtherRemarks{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FScanPoint { get; set; }
        /// <summary>
        /// 单据体
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Ar_OtherReceivable_Entry> FEntity { get; set; }
    }
    public class Ar_OtherReceivableSaveInputDto : Ar_OtherReceivableSaveInputDto<Ar_OtherReceivable_Entry>
    { }
}
