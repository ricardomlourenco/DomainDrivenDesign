using System;
using System.Collections.Generic;
using DomainDrivenDesign.Application.ViewModels;

namespace DomainDrivenDesign.Application.Interfaces
{
    public interface ISecurityAppService: IDisposable
    {
        IEnumerable<SecurityViewModel> GetAll();
        IEnumerable<SecurityViewModel> Search(SecuritySearch model);
        IEnumerable<SecurityViewModel> SearchByCode(string model); 
    }
}
