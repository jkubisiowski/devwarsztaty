using System;
using System.Threading.Tasks;
using DevWarsztaty.Messages.Events;

namespace DevWarsztaty.WebApi.Handlers
{
    public class CreateRecordFailedHandler : IEventHandler<CreateRecordFailed>
    {
        public async Task HandleAsync(CreateRecordFailed@event)
        {
            Console.WriteLine($"Record {@event.Key} was not created for reason {@event.Reason}");
            await Task.CompletedTask;
        }
    }
}