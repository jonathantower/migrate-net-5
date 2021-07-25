using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;

namespace Demo.UI.Web.Controllers.Api
{
    [ApiController]
    public class DataController : Controller
    {
        private ClassLibrary.Math _math = new ClassLibrary.Math();

        [HttpGet("api/data")]
        public IEnumerable<string> Get()
        {
            Thread.Sleep(2000);
            return _math.FamousMathematicians();
        }
    }
}
