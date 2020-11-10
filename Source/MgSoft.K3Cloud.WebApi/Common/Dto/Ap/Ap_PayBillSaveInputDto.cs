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
        public long? FID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBillTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBillNo { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FDATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCONTACTUNITTYPE { get; set; }
        /// <summary>
        /// 往来单位(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FCONTACTUNIT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FRECTUNITTYPE { get; set; }
        /// <summary>
        /// 收款单位(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FRECTUNIT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FDepartment { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISINIT { get; set; }
        /// <summary>
        /// 币别(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FCURRENCYID { get; set; } = new FNumberProperty("PRE001");//人民币
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FEXCHANGERATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FSETTLERATE { get; set; }
        /// <summary>
        /// 结算组织(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FSETTLEORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPURCHASEORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPURCHASEDEPTID { get; set; }
        /// <summary>
        /// 采购组织(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FPURCHASERGROUPID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPURCHASERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FDOCUMENTSTATUS { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBUSINESSTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FScanPoint { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCancelStatus { get; set; }
        /// <summary>
        /// 付款组织(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FPAYORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISSAMEORG { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsCredit { get; set; }
        /// <summary>
        /// 结算币别(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FSETTLECUR { get; set; } = new FNumberProperty("PRE001");//人民币
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsWriteOff { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FMatchMethodID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FREALPAY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FREMARK { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FBookingDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FTHIRDBILLNO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FWBSETTLENO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISCARRYRATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSETTLEMAINBOOKID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FGYSHOPNAME { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FGYCUSTOMERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ap_PayBill_Entry> FPAYBILLENTRY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ap_PayBill_SrcEntry> FPAYBILLSRCENTRY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ap_PayBill_PayableEntry> FBILLPAYABLEENTRY { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ap_PayBill_ReceivableEntry> FBILLRECEIVABLEENTRY { get; set; }         
    
    }
    public class Ap_PayBillSaveInputDto : Ap_PayBillSaveInputDto<
        Ap_PayBill_Entry,
        Ap_PayBill_SrcEntry,
        Ap_PayBill_PayableEntry,
        Ap_PayBill_ReceivableEntry>
    { }
}
