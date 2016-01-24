using System.Web.Mvc;

namespace DomainDrivenDesign.UI.Mvc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Contact()
        {
            return View();
        }

        public ViewResult Architecture()
        {
            return View();
        }
	}
}