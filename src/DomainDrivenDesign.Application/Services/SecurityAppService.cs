using System;
using System.Collections.Generic;
using AutoMapper;
using DomainDrivenDesign.Application.Interfaces;
using DomainDrivenDesign.Application.ViewModels;
using DomainDrivenDesign.Domain.Entities;
using DomainDrivenDesign.Domain.Interfaces.Services;

namespace DomainDrivenDesign.Application.Services
{
    public class SecurityAppService: ISecurityAppService
    {
        private readonly ISecurityService _securityDomainService;

        public SecurityAppService(ISecurityService securityDomainService)
        {
            _securityDomainService= securityDomainService;
        }

        public IEnumerable<SecurityViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Security>, IEnumerable<SecurityViewModel>>(_securityDomainService.GetAll());
        }

        public void Dispose()
        {
            _securityDomainService.Dispose();
        }

        /// <summary>
        /// The Search filters and complexity to perform a Search are isolates in the Application tier
        /// which simplifies the code, improve quality, testability and scalability
        /// We can easly use this layer to invoke searches from any UI such as Asp.Net Mvc, Mobile, WebApi, etc. 
        /// once all filters and complexity are located here and it's not needed ctrl + C, V, just reuse the code
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IEnumerable<SecurityViewModel> SearchByModel(SecuritySearch model)
        {
            IEnumerable<Security> securitiesDomain = null;

            if (model.NameToSearch != null)
            {
                securitiesDomain = _securityDomainService.Search(security => security.SecurityCode.Trim().StartsWith(model.NameToSearch.Trim(), StringComparison.CurrentCultureIgnoreCase));
            }

            if (model.TextToSearch != null)
            {
                securitiesDomain = _securityDomainService.SearchByAnyText(model.TextToSearch);
            }

            return Mapper.Map<IEnumerable<Security>, IEnumerable<SecurityViewModel>>(securitiesDomain);
        }

        public IEnumerable<SecurityViewModel> SearchByCode(string code)
        {
            var result = _securityDomainService.Search(security => security.SecurityCode.Trim().StartsWith(code, StringComparison.CurrentCultureIgnoreCase));
            return Mapper.Map<IEnumerable<Security>, IEnumerable<SecurityViewModel>>(result);
        }

        public SecurityViewModel Add(SecurityViewModel entity)
        {
            var domainEntity = Mapper.Map<SecurityViewModel, Security>(entity);
            return Mapper.Map<Security, SecurityViewModel>(_securityDomainService.Add(domainEntity));
        }

        public SecurityViewModel GetById(int id)
        {
            return Mapper.Map<Security, SecurityViewModel>(_securityDomainService.GetById(id));
        }

        public SecurityViewModel Update(SecurityViewModel entity)
        {
            var result = _securityDomainService.Update(Mapper.Map<SecurityViewModel, Security>(entity));
            return Mapper.Map<Security, SecurityViewModel>(result);
        }

        public void Delete(int id)
        {
            _securityDomainService.Delete(id);
        }

        public IEnumerable<SecurityViewModel> Search(Func<SecurityViewModel, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
