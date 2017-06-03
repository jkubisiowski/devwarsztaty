using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevWarsztaty.Messages.Commands;
using DevWarsztaty.Messages.Events;
using RawRabbit;

namespace DevWarsztaty.Service.Handlers
{
    public class CreateRecordHandler : 
        DevWarsztaty.Messages.Commands.ICommadHandler<CreateRecord>
    {
        private readonly IBusClient _busClient;

        public CreateRecordHandler(IBusClient busClient)
        {
            _busClient = busClient;
        }

        public async Task HandleAsync(CreateRecord command)
        {
            Console.WriteLine($"Received record {command.Key}");
            if (string.IsNullOrWhiteSpace(command.Key))
            {
                await _busClient.PublishAsync(new CreateRecordFailed(command.Key, "Record key canot be empty"));
                return;
            }
            await _busClient.PublishAsync(new RecordCreated(command.Key));
        }
    }
}
