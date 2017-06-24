using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Fibon.Api.Controllers{
    [Route("[controller]")]
    public class FibonacciController: Controller{
        [HttpGet("{numer}")]
        public async Task<IActionResult> Get(int number)
        {
            return Content(number.ToString());
        }
        [HttpPost("{numer}")]
        public async Task<IActionResult> Post(int number)
        {
            return Accepted($"fibonacci/{number}", null);
        }
    }
}