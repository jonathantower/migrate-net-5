using System.Configuration;
using Demo.UI.Web2.Config;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Demo.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        private AppSettings _appSettings;

        public HomeController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //ViewBag.AppVersion = ConfigurationManager.AppSettings["appVersion"];
            ViewBag.AppVersion = _appSettings.AppVersion;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}