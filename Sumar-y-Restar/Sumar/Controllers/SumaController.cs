using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sumar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SumaController : ControllerBase
    {
        [HttpGet]
        public int Add(int a, int b)
        {
            return a+b;
        }
        [HttpPost]
        public int Add2([FromHeader]int a, [FromHeader] int b)
        {
            return a + b;
        }
    }
}
