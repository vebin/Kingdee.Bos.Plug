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
        public long? FID{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBillTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBillNo{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FDATE{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FENDDATE_H{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISINIT { get; set; }
        /// <summary>
        /// 往来单位类型
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCONTACTUNITTYPE{ get; set; }
        /// <summary>
        /// 往来单位(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FCONTACTUNIT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FAMOUNTFOR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FCURRENCYID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FDEPARTMENTID { get; set; }
        /// <summary>
        /// 结算组织(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FSETTLEORGID { get; set; }
        /// <summary>
        /// 收款组织(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FPAYORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSALEDEPTID { get; set; }
        /// <summary>
        /// 销售组织(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FSALEORGID{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSALEGROUPID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSALEERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FACCNTTIMEJUDGETIME{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSettleTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FMAINBOOKSTDCURRID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FEXCHANGETYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FExchangeRate{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FNOTAXAMOUNT{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FTAXAMOUNT{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCancelStatus{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FAR_OtherRemarks{ get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FScanPoint { get; set; }
        /// <summary>
        /// 单据体
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ar_OtherReceivable_Entry> FEntity { get; set; }
    }
    public class Ar_OtherReceivableSaveInputDto : Ar_OtherReceivableSaveInputDto<Ar_OtherReceivable_Entry>
    { }
}
