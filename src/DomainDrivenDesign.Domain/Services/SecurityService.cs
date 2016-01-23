﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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

        public IEnumerable<Entities.Security> GetAll()
        {
            return _securityRepository.GetAll();
        }

        public IEnumerable<Entities.Security> Search(Func<Entities.Security, bool> predicate)
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
    }
}