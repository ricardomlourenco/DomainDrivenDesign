using System.Collections.Generic;
using System.Web.Http;
using DomainDrivenDesign.Application.Interfaces;
using DomainDrivenDesign.Application.ViewModels;

namespace DomainDrivenDesign.Services.SecurityAPI.Controllers
{
    public class SecurityController : ApiController
    {
        private ISecurityAppService _securityAppService;

        public SecurityController(ISecurityAppService securityAppService)
        {
            _securityAppService = securityAppService;
        }

        // GET api/security
        public IEnumerable<SecurityViewModel> Get()
        {
            return _securityAppService.GetAll();
        }

        // GET api/security/GOOG
        public IEnumerable<SecurityViewModel> Get(string id)
        {
            return _securityAppService.SearchByCode(id);
        }
    }
}
