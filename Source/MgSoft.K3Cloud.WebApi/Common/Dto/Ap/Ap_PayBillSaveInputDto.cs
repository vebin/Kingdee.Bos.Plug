using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ap
{
    /// <summary>
    /// 付款单
    /// </summary>
    public class Ap_PayBillSaveInputDto<
        Type_Ap_PayBill_Entry,
        Type_Ap_PayBill_SrcEntry,
        Type_Ap_PayBill_PayableEntry,
        Type_Ap_PayBill_ReceivableEntry>
        where Type_Ap_PayBill_Entry : Ap_PayBill_Entry
        where Type_Ap_PayBill_SrcEntry : Ap_PayBill_SrcEntry
        where Type_Ap_PayBill_PayableEntry : Ap_PayBill_PayableEntry
        where Type_Ap_PayBill_ReceivableEntry : Ap_PayBill_ReceivableEntry
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FBillTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FBillNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FDATE { get; set; }
        /// <summary>
        /// 往来单位(必填)
        /// </summary>
        [JsonRequired]
        public virtual string FCONTACTUNITTYPE { get; set; }
        /// <summary>
        /// 往来单位(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FCONTACTUNIT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FRECTUNITTYPE { get; set; }
        /// <summary>
        /// 收款单位(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FRECTUNIT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FDepartment { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISINIT { get; set; }
        /// <summary>
        /// 币别(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FCURRENCYID { get; set; } = new FNumberProperty("PRE001");//人民币
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FEXCHANGERATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FSETTLERATE { get; set; }
        /// <summary>
        /// 结算组织(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FSETTLEORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPURCHASEORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPURCHASEDEPTID { get; set; }
        /// <summary>
        /// 采购组织(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FPURCHASERGROUPID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPURCHASERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FDOCUMENTSTATUS { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FBUSINESSTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FScanPoint { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FCancelStatus { get; set; }
        /// <summary>
        /// 付款组织(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FPAYORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISSAMEORG { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FIsCredit { get; set; }
        /// <summary>
        /// 结算币别(必填)
        /// </summary>
        [JsonRequired]
        public virtual FNumberProperty FSETTLECUR { get; set; } = new FNumberProperty("PRE001");//人民币
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FIsWriteOff { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? FMatchMethodID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FREALPAY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FREMARK { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FBookingDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FTHIRDBILLNO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FWBSETTLENO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISCARRYRATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSETTLEMAINBOOKID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FGYSHOPNAME { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FGYCUSTOMERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Ap_PayBill_Entry> FPAYBILLENTRY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Ap_PayBill_SrcEntry> FPAYBILLSRCENTRY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Ap_PayBill_PayableEntry> FBILLPAYABLEENTRY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Ap_PayBill_ReceivableEntry> FBILLRECEIVABLEENTRY { get; set; }         
    
    }
    public class Ap_PayBillSaveInputDto : Ap_PayBillSaveInputDto<
        Ap_PayBill_Entry,
        Ap_PayBill_SrcEntry,
        Ap_PayBill_PayableEntry,
        Ap_PayBill_ReceivableEntry>
    { }
}
