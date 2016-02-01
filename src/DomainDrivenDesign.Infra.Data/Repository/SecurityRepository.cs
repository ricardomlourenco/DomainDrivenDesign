using System;
using System.Collections.Generic;
using System.Linq;
using DomainDrivenDesign.Domain.Entities;
using DomainDrivenDesign.Domain.Interfaces.Repository;
using DomainDrivenDesign.Infra.Data.Context;

namespace DomainDrivenDesign.Infra.Data.Repository
{
    public class SecurityRepository: Repository<Security>, ISecurityRepository
    {
        public SecurityRepository(DefaultORMContext dbContext): base (dbContext)
        {

        }

        public string GetISINbySedol(string sedol)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Security> SearchByAnyText(string text)
        {
            var parameter = text.Trim();

            var result =
                from security in _dbSet.ToList()
                where
                 security.SecurityCode.IndexOfIgnoringNullAndEmpty(parameter) != -1 ||
                 security.SecurityName.IndexOfIgnoringNullAndEmpty(parameter) != -1 ||
                 security.Sedol.IndexOfIgnoringNullAndEmpty(parameter) != -1 ||
                 security.Isin.IndexOfIgnoringNullAndEmpty(parameter) != -1 ||
                 security.Cusip.IndexOfIgnoringNullAndEmpty(parameter) != -1
                 orderby security.SecurityName
                 select security;

            return result;
        }
    }
}
