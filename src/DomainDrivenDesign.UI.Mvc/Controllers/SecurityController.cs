using System;
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

        #region Search

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
            model.Securities = _securityAppService.SearchByModel(model);
            return View(model);
        }

        [ValidateAntiForgeryToken]
        public PartialViewResult SearchResultPartial(SecuritySearch model)
        {
            return PartialView(_securityAppService.SearchByModel(model));
        }

        public ActionResult SearchjQuery()
        {
            var securities = _securityAppService.GetAll();
            var model = new SecuritySearch() { Securities = securities };
            return View(model);
        }

        #endregion

        #region Create

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SecurityViewModel securityViewModel)
        {
            if (ModelState.IsValid)
            {
                _securityAppService.Add(securityViewModel);
                return RedirectToAction("Search");
            }

            return View();
        }

        #endregion  

        #region Edit

        public ActionResult Edit(SecurityViewModel securityViewModel)
        {
            if (ModelState.IsValid)
            {
                _securityAppService.Update(securityViewModel); 
            }

            return RedirectToAction("Search");
        }


        #endregion

        #region Delete

        public ActionResult Delete(int id)
        {
            _securityAppService.Delete(id);
            return RedirectToAction("Search");
        }

        #endregion
    }
}