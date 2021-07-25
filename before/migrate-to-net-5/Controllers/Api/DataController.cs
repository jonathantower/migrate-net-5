using System.Collections.Generic;
using System.Threading;
using System.Web.Http;

namespace Demo.UI.Web.Controllers.Api
{
    public class DataController : ApiController
    {
        private ClassLibrary.Math _math = new ClassLibrary.Math();

        public IEnumerable<string> Get()
        {
            Thread.Sleep(2000);
            return _math.FamousMathematicians();
        }
    }
}
