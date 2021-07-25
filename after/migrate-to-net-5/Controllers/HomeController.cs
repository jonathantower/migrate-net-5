using System.Configuration;
using System.Web.Mvc;

namespace Demo.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            ViewBag.AppVersion = ConfigurationManager.AppSettings["appVersion"];

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}