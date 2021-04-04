using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.CommandHandlers
{
    public abstract class CommandHandlerBase
    {
        public ParsedCommand ParsedCommand { get; }
        public abstract void Execute();
        protected CommandHandlerBase(ParsedCommand parsedCommand)
        {
            ParsedCommand = parsedCommand;
        }
    }
}
