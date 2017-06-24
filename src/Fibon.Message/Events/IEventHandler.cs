using System.Threading.Tasks;

namespace Fibon.Message.Events {

    public interface IEventHandler<in T> where T: IEvent
    {   
        Task HandleAsync(T @event);
    }
}