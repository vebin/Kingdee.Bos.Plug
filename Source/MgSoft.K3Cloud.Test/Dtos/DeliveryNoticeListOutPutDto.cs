using MgSoft.K3Cloud.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgSoft.K3Cloud.Test.Dtos
{
    public class DeliveryNoticeListOutPutDto
    {
        /// <summary>
        /// 单据编号
        /// </summary>
        [ValueDicName("FBillNo")]
        public string BillNo { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        [ValueDicName("FCUSTOMERID.FName")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 客户联系电话
        /// </summary>
        [ValueDicName("FCUSTOMERID.FTEL")]
        public string CustomerTel { get; set; }
    }
}
