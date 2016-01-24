using System.Web.Mvc;
using DomainDrivenDesign.Application.Interfaces;
using DomainDrivenDesign.Application.ViewModels;

namespace DomainDrivenDesign.UI.Mvc.Controllers
{
    public class SecurityController : Controller
    {
        private readonly ISecurityAppService _securityAppService;

        public SecurityController(ISecurityAppService securityAppService)
        {
            _securityAppService = securityAppService;
        }
        public ActionResult Index()
        {
            return RedirectToAction("Search");
        }

        public ActionResult Search()
        {
            var securities = _securityAppService.GetAll();
            var model = new SecuritySearch() { Securities = securities };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Search(SecuritySearch model)
        {
            model.Securities = _securityAppService.Search(model);
            return View(model);
        }

        [ValidateAntiForgeryToken]
        public PartialViewResult SearchResultPartial(SecuritySearch model)
        {

            /// Slowing the method in Debug mode to be able to see the "Loading" feature 
#if DEBUG
            //System.Threading.Thread.Sleep(1000);
            //throw new ArgumentException();
#endif
            
            return PartialView(_securityAppService.Search(model));
        }

        public ActionResult SearchjQuery()
        {
            var securities = _securityAppService.GetAll();
            var model = new SecuritySearch() { Securities = securities };
            return View(model);
        }
	}
}