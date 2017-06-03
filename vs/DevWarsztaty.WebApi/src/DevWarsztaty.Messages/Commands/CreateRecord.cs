using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevWarsztaty.Messages.Commands
{
    public class CreateRecord : ICommand
    {
        public string Key { get; set; }
        public object Value { get; set; }
    }
}
