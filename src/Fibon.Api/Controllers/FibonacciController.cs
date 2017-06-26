using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using RawRabbit;
using Fibon.Api.Repository;
using Fibon.Message.Commands;
using System.Collections.Generic;

namespace Fibon.Api.Controllers{
    [Route("[controller]")]    
    public class FibonacciController: Controller{

        private readonly IBusClient _busClient;
        private readonly IRepository _repository;
        public FibonacciController(IBusClient busClient, IRepository repository)
        {
            _busClient = busClient;
            _repository = repository;
        }

        [HttpGet("{number}")]
        public IActionResult Get(int number)
        {
            int? inCache = _repository.Get(number);
            if (inCache.HasValue)
            {
                return Content(inCache.Value.ToString());
            }

            return NotFound();
        }

        [HttpGet("queue")]
        public IActionResult Queue()
        {
            string response = String.Empty;
            foreach (var val in _repository.GetAll())
                response += String.Format("[{0}]:[{1}]; ", val.Key, val.Value);
            
            return Content(response);
        }

		[HttpPost("{number}")]
		public async Task<IActionResult> Post(int number)
		{
		    int? inCache = _repository.Get(number);
		    if (!inCache.HasValue)
		    {
		        await _busClient.PublishAsync(new CalculateValueCommand(number));
            }
            
            return Accepted($"fibonacci/{number}", null);
		}
    } 
}