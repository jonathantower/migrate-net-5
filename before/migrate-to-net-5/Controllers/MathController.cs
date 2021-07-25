using System.Web.Mvc;

namespace Demo.UI.Web.Controllers
{
    public class MathController : Controller
    {
        private ClassLibrary.Math _math = new ClassLibrary.Math();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add(int AddNumber1, int AddNumber2)
        {
            ViewBag.AddResult = _math.Add(AddNumber1, AddNumber2);
            return View("Index");
        }

        public ActionResult Subtract(int SubtractNumber1, int SubtractNumber2)
        {
            ViewBag.SubtractResult = _math.Subtract(SubtractNumber1, SubtractNumber2);
            return View("Index");
        }

        public ActionResult Multiply(int MultiplyNumber1, int MultiplyNumber2)
        {
            ViewBag.MultiplyResult = _math.Multiply(MultiplyNumber1, MultiplyNumber2);
            return View("Index");
        }

        public ActionResult Divide(int DivideNumber1, int DivideNumber2)
        {
            ViewBag.DivideResult = _math.Divide(DivideNumber1, DivideNumber2);
            return View("Index");
        }
    }
}