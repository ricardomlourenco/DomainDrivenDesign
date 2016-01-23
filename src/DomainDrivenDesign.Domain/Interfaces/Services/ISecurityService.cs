using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DomainDrivenDesign.Domain.Entities;

namespace DomainDrivenDesign.Domain.Interfaces.Services
{
    public interface ISecurityService: IDisposable
    {
        IEnumerable<Security> GetAll();
        IEnumerable<Security> Search(Func<Security, bool> predicate);
        IEnumerable<Security> SearchByAnyText(string text);
    }
}
