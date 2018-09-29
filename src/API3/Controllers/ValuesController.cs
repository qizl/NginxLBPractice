using Microsoft.AspNetCore.Mvc;

namespace API3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            var assembly = System.Reflection.Assembly.GetAssembly(typeof(ValuesController));

            return assembly.GetName().Name;
        }
    }
}
