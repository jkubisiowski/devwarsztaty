using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevWarsztaty.Messages.Commands;

namespace DevWarsztaty.Messages.Events
{
    public class RecordCreated : IEvent
    {
        protected RecordCreated()
        {
            
        }

        public RecordCreated(string key)
        {
            Key = key;
        }

        public string Key { get; }
    }
}
