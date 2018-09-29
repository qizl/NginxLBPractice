using Microsoft.AspNetCore.Mvc;

namespace API1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get() => System.Reflection.Assembly.GetAssembly(typeof(ValuesController)).GetName().Name;
    }
}
