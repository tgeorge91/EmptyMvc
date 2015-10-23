using System.Web.Mvc;

namespace EmptyMvc.Api
{
    public class MvcController : Controller
    {
        [HttpGet]
        [Route("api/testapi")]
        public string TestFuction()
        {
            return "The test was successful";
        }
    }
}