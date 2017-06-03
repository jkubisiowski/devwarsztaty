using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevWarsztaty.Messages.Events
{
    public class RecordCreated
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
