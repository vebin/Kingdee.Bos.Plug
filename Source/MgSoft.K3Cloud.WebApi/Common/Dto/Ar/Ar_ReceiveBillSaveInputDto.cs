using MgSoft.K3Cloud.WebApi.Common.Dto.Property;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi.Common.Dto.Ar
{
    /// <summary>
    /// 收款单
    /// </summary>
    public class Ar_ReceiveBillSaveInputDto<
        Type_Ar_ReceiveBill_Entry,
        Type_Ar_ReceiveBill_SrcEntry,
        Type_Ar_ReceiveBill_FBillReceivableEntry,
        Type_Ar_ReceiveBill_FBILLSKDRECENTRY>
        where Type_Ar_ReceiveBill_Entry : Ar_ReceiveBill_Entry
        where Type_Ar_ReceiveBill_SrcEntry : Ar_ReceiveBill_SrcEntry
        where Type_Ar_ReceiveBill_FBillReceivableEntry : Ar_ReceiveBill_FBillReceivableEntry
        where Type_Ar_ReceiveBill_FBILLSKDRECENTRY : Ar_ReceiveBill_FBILLSKDRECENTRY
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? FID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FBillTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBillNo { get; set; }
        /// <summary>
        /// 业务日期(必填)
        /// </summary>
        [JsonRequired]
        public DateTime? FDATE { get; set; } = DateTime.Now;
        /// <summary>
        /// 往来单位类型(必填) 备注:不需要给值，使用系统默认值
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCONTACTUNITTYPE { get; set; }
        /// <summary>
        /// 往来单位(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FCONTACTUNIT { get; set; }
        /// <summary>
        /// 付款单位类型(必填) 备注:不需要给值，使用系统默认值
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FPAYUNITTYPE { get; set; }
        /// <summary>
        /// 付款单位(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FPAYUNIT { get; set; }
        /// <summary>
        /// 币别
        /// </summary>
        [JsonRequired]
        public FNumberProperty FCURRENCYID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FPAYORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FSETTLERATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSETTLEORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSALEORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSALEDEPTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSALEGROUPID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSALEERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FDOCUMENTSTATUS { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FDepartment { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FBUSINESSTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISINIT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FEXCHANGERATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FCancelStatus { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FScanPoint { get; set; }
        /// <summary>
        /// 结算币别(必填)
        /// </summary>
        [JsonRequired]
        public FNumberProperty FSETTLECUR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FISB2C { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? FIsWriteOff { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FMatchMethodID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FKDPAYNO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FREMARK { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FTHIRDBILLNO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FNumberProperty FSETTLEMAINBOOKID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FISCARRYRATE { get; set; }
        /// <summary>
        /// 明细信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ar_ReceiveBill_Entry> FRECEIVEBILLENTRY { get; set; }
        /// <summary>
        /// 收款单源单明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ar_ReceiveBill_SrcEntry> FRECEIVEBILLSRCENTRY { get; set; }
        /// <summary>
        /// 应收票据明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ar_ReceiveBill_FBillReceivableEntry> FBILLRECEIVABLEENTRY { get; set; }
        /// <summary>
        /// 应收票据背书
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Ar_ReceiveBill_FBILLSKDRECENTRY> FBILLSKDRECENTRY { get; set; }

    }

    public class Ar_ReceiveBillSaveInputDto : Ar_ReceiveBillSaveInputDto<
        Ar_ReceiveBill_Entry,
        Ar_ReceiveBill_SrcEntry,
        Ar_ReceiveBill_FBillReceivableEntry,
        Ar_ReceiveBill_FBILLSKDRECENTRY
        >
    { }
}
