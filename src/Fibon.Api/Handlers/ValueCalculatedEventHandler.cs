using System.Threading.Tasks;
using Fibon.Api.Repository;
using Fibon.Message.Events;
using RawRabbit;

namespace Fibon.Api.Handlers
{
    public class ValueCalculatedEventHandler : IEventHandler<ValueCalculatedEvent>
    {
		private readonly IBusClient _bus;
        private readonly IRepository _repository;

        public ValueCalculatedEventHandler(IBusClient bus, IRepository repositoryu)
		{
			_bus = bus;
			_repository = repositoryu;
		}

		public async Task HandleAsync(ValueCalculatedEvent @event)
		{
            _repository.Insert(@event.Number, @event.Result);
            await Task.CompletedTask;
		}
    }
}
