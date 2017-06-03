using System.Threading.Tasks;
using DevWarsztaty.Messages.Commands;

namespace DevWarsztaty.Messages.Events
{
    public interface IEventHandler<T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}