using MgSoft.K3Cloud.WebApi.Common.Dto.Ar;

namespace MgSoft.K3Cloud.WebApi.Common.Api.Ar
{
    public interface IAr_RefundBillApi : IWebApi
    {
        bool Save(Ar_RefundSaveInputDtp Ar_RefundSaveInputDtp);
    }
}