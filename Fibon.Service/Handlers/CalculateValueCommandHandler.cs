using System.Threading.Tasks;
using Fibon.Message.Commands;
using Fibon.Message.Events;
using RawRabbit;

namespace Fibon.Service.Handlers
{
    public class CalculateValueCommandHandler : ICommandHandler<CalculateValueCommand>
    {
        private readonly IBusClient _bus;
        private readonly ICalculator _calculator;

        public CalculateValueCommandHandler(IBusClient bus, ICalculator calculator)
        {
            _bus = bus;
            _calculator = calculator;
        }

        public async Task HandleAsync(CalculateValueCommand command)
        {
            int result = _calculator.CalculateFibonacci(command.Number);
            await _bus.PublishAsync(new ValueCalculatedEvent(command.Number, result));
        }
    }
}