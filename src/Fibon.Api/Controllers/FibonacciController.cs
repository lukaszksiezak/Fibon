using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using RawRabbit;
using Fibon.Api.Repository;
using Fibon.Message.Commands;

namespace Fibon.Api.Controllers{
    [Route("[controller]")]    
    public class FibonacciController: Controller{

        private readonly IBusClient _busClient;
        private readonly IRepository _repository;
        public FibonacciController(IBusClient bus, IRepository repository){
            _busClient = bus; 
            _repository = repository;           
        }

        [HttpGet("{numer}")]
        public async Task<IActionResult> Get(int number)
        {
            int? inCache = _repository.Get(number);
            if(inCache.HasValue){
                return Content(inCache.Value.ToString());
            }
            return NotFound();
        }
        [HttpPost("{numer}")]
        public async Task<IActionResult> Post(int number)
        {
            int? inCache = _repository.Get(number);
            if(inCache.HasValue){
                await _busClient.PublishAsync(new CalculateValueCommand(number));
            }
            return Accepted($"fibonacci/{number}", null);
        }

    }    
}