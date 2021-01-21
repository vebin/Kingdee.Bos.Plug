using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApi
{
    public interface IWebApi: IApi
    {
        List<AuditOutputDto> Audit(AuditInputDto auditInputDto);
        List<DeleteOutputDto> Delete(DeleteInputDto deleteInputDto);
        bool Exist(string filterString, string fileds = "FId");
        T Get<T>(string formId, long id) where T : class;
        T Get<T>(string formId, string number) where T : class;
        T Get<T>(GetInputDto getInputDto) where T : class;
        List<T> GetList<T>(GetListInputDto getListInputDto) where T : class, new();
        List<PushOutputDto> Push(PushInputDto PushInputDto);
        List<SaveOutPutDto> Save(SaveInputDto saveInputDto);
        List<SubmitOutputDto> Submit(SubmitInputDto submitInputDto);
        List<UnAuditOutputDto> UnAudit(UnAuditInputDto unAuditInputDto);
    }
}
