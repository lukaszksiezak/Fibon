using System;
using Microsoft.AspNetCore.Mvc;

namespace Fibon.Api.Controllers{
    public class HomeController: Controller{
        [HttpGet("")]
        public IActionResult Get()
        {
            return Content("Hello from API");
        }
    }
}