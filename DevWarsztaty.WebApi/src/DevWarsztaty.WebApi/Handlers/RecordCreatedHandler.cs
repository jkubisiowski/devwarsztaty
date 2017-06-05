using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevWarsztaty.Messages.Commands;
using DevWarsztaty.Messages.Events;
using DevWarsztaty.WebApi.Storage;

namespace DevWarsztaty.WebApi.Handlers
{
    public class RecordCreatedHandler : IEventHandler<RecordCreated>, ICommand
    {
        private readonly IStorage _storage;

        public RecordCreatedHandler(IStorage storage)
        {
            _storage = storage;
        }
        public async Task HandleAsync(RecordCreated @event)
        {
            Console.WriteLine($"Record {@event.Key} was created.");
            _storage.Add(@event.Key);
            await Task.CompletedTask;
        }
    }
}
