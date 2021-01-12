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
        public virtual long? FID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FBillTypeID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FBillNo { get; set; }
        /// <summary>
        /// 业务日期(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? FDATE { get; set; } = DateTime.Now;
        /// <summary>
        /// 往来单位类型(必填) 备注:不需要给值，使用系统默认值
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FCONTACTUNITTYPE { get; set; }
        /// <summary>
        /// 往来单位(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCONTACTUNIT { get; set; }
        /// <summary>
        /// 付款单位类型(必填) 备注:不需要给值，使用系统默认值
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FPAYUNITTYPE { get; set; }
        /// <summary>
        /// 付款单位(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPAYUNIT { get; set; }
        /// <summary>
        /// 币别
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FCURRENCYID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FPAYORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FSETTLERATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSETTLEORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSALEORGID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSALEDEPTID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSALEGROUPID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSALEERID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FDOCUMENTSTATUS { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FDepartment { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FBUSINESSTYPE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISINIT { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FEXCHANGERATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FCancelStatus { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FScanPoint { get; set; }
        /// <summary>
        /// 结算币别(必填)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSETTLECUR { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FISB2C { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? FIsWriteOff { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FMatchMethodID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FKDPAYNO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FREMARK { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FTHIRDBILLNO { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual FNumberProperty FSETTLEMAINBOOKID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual decimal? FISCARRYRATE { get; set; }
        /// <summary>
        /// 明细信息
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Ar_ReceiveBill_Entry> FRECEIVEBILLENTRY { get; set; }
        /// <summary>
        /// 收款单源单明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Ar_ReceiveBill_SrcEntry> FRECEIVEBILLSRCENTRY { get; set; }
        /// <summary>
        /// 应收票据明细
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Ar_ReceiveBill_FBillReceivableEntry> FBILLRECEIVABLEENTRY { get; set; }
        /// <summary>
        /// 应收票据背书
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<Type_Ar_ReceiveBill_FBILLSKDRECENTRY> FBILLSKDRECENTRY { get; set; }

    }

    public class Ar_ReceiveBillSaveInputDto : Ar_ReceiveBillSaveInputDto<
        Ar_ReceiveBill_Entry,
        Ar_ReceiveBill_SrcEntry,
        Ar_ReceiveBill_FBillReceivableEntry,
        Ar_ReceiveBill_FBILLSKDRECENTRY
        >
    { }
}
