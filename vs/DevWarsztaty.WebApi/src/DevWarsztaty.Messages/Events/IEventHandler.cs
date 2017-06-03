using System.Threading.Tasks;
using DevWarsztaty.Messages.Commands;

namespace DevWarsztaty.Messages.Events
{
    public interface IEventHandler<T> where T : IEvent
    {
        Task HandleAsync(T command);
    }
}