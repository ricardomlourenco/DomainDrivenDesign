using System.Collections.Generic;
using DomainDrivenDesign.Application.ViewModels;

namespace DomainDrivenDesign.Application.Interfaces
{
    public interface ISecurityAppService : IAppServiceBase<SecurityViewModel>
    {
        IEnumerable<SecurityViewModel> SearchByCode(string model); 
        IEnumerable<SecurityViewModel> SearchByModel(SecuritySearch model); 
    }
}
