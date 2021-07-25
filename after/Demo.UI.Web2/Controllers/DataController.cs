using Microsoft.AspNetCore.Mvc;

namespace Demo.UI.Web.Controllers
{
    public class DataController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}