using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevWarsztaty.Messages.Commands;
using DevWarsztaty.Messages.Events;

namespace DevWarsztaty.WebApi.Handlers
{
    public class RecordCreatedHandler : IEventHandler<RecordCreated>, ICommand
    {
        public async Task HandleAsync(RecordCreated @event)
        {
            Console.WriteLine($"Record {@event.Key} was created.");
            await Task.CompletedTask;
        }
    }
}
