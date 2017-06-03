using System.Threading.Tasks;

namespace DevWarsztaty.Messages.Commands
{
    public interface ICommadHandler<T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}