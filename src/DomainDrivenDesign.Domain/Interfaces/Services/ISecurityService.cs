using System;
using System.Collections.Generic;
using DomainDrivenDesign.Domain.Entities;

namespace DomainDrivenDesign.Domain.Interfaces.Services
{
    public interface ISecurityService: IServiceBase<Security>
    {
        IEnumerable<Security> SearchByAnyText(string text);
    }
}

