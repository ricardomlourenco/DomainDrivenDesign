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
        public SecurityRepository(DefaultORMContext dbContext) : base(dbContext)
        {

        }

        private readonly List<Security> securities = new List<Security>()
            {
                new Security() { SecurityId = 1, SecurityCode="GOOG", SecurityName="GOOGLE" },
                new Security() { SecurityId = 2, SecurityCode = "YAHOO", SecurityName = "YAHOO" },
                new Security() { SecurityId = 3, SecurityCode = "APPPL", SecurityName = "APPLE" }
            };

        /// <summary>
        /// TODO: Repository to be implemented
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public override IEnumerable<Security> Search(Func<Security, bool> predicate)
        { 
            return securities.Where(predicate);
        }
        
        /// <summary>
        /// Limiting the maxing number for return ALL.
        /// It's very dangerous return all results from database without pagination
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Security> GetAll()
        {
            return securities.Take(10);
        }

        public string GetISINbySedol(string sedol)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Security> SearchByAnyText(string text)
        {
            var parameter = text.Trim();

            var result =
                from security in securities 
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
