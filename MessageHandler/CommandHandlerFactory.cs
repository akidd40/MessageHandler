using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageHandler.CommandHandlers;

namespace MessageHandler
{
    public static class CommandHandlerFactory
    {
        public static CommandHandlerBase GetHandler(ParsedCommand parsedCommand)
        {
            switch (parsedCommand.Command)
            {
                case Command.Add:
                {
                    return new AddCommandHandler(parsedCommand);
                }
                case Command.List:
                {
                    return new ListCommandHandler(parsedCommand);
                }
                default:
                {
                    throw new InvalidOperationException($"No handler found for command {parsedCommand.Command}");
                }
            }
        }
    }
}
