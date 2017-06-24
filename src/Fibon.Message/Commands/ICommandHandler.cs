using System.Threading.Tasks;

namespace Fibon.Message.Commands {

    public interface ICommandHandler<in T> where T: ICommand
    {   
        Task HandleAsync(T ICommand);
    }
}