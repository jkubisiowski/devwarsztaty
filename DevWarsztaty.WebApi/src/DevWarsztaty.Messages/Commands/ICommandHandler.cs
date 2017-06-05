using System.Threading.Tasks;

namespace DevWarsztaty.Messages.Commands
{
    public interface ICommandHandler<T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}