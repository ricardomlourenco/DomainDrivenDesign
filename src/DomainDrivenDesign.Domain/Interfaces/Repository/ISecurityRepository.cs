using System.Collections.Generic;
using DomainDrivenDesign.Domain.Entities;

namespace DomainDrivenDesign.Domain.Interfaces.Repository
{
    public interface ISecurityRepository: IRepository<Security> 
    {
        /// In case we need something specific for Security, it should be impelemented here, not in the Generic Repository
        /// For example Get ISIN by Sedol
        string GetISINbySedol(string sedol);

        IEnumerable<Security> SearchByAnyText(string text);

    }
}
