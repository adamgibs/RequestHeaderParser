using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace RequestHeaderParser.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult GetIp()
        {
            IList output = new List<object>();

            var ipAdd = Request.Headers;

            output.Add(new { IpAddress = ipAdd["X-Original-For"], Language = ipAdd["Accept-Language"], Software = ipAdd["User-Agent"] });
            return new JsonResult(output);
        }

       
    }
}
