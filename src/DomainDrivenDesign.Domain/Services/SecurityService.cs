using System;
using System.Collections.Generic;
using DomainDrivenDesign.Domain.Entities;
using DomainDrivenDesign.Domain.Interfaces.Repository;
using DomainDrivenDesign.Domain.Interfaces.Services;

namespace DomainDrivenDesign.Domain.Services
{
    public class SecurityService : ISecurityService
    {
        private readonly ISecurityRepository _securityRepository;

        public SecurityService(ISecurityRepository securityRepository)
        {
            _securityRepository = securityRepository;
        }

        public IEnumerable<Security> GetAll()
        {
            return _securityRepository.GetAll();
        }

        public IEnumerable<Security> Search(Func<Security, bool> predicate)
        {
            return _securityRepository.Search(predicate);
        }

        public void Dispose()
        {
            _securityRepository.Dispose();
        }

        public IEnumerable<Security> SearchByAnyText(string text)
        {
            return _securityRepository.SearchByAnyText(text);
        }

        public Security Add(Security entity)
        {
            return _securityRepository.Add(entity);
        }

        public Security GetById(int id)
        {
            return _securityRepository.GetById(id);
        }

        public Security Update(Security entity)
        {
            return _securityRepository.Update(entity);
        }

        public void Delete(int id)
        {
            _securityRepository.Delete(id);
        }
    }
}
