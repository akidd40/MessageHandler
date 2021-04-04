using System;

namespace MessageHandler.CommandHandlers
{
    public class ListCommandHandler : CommandHandlerBase
    {
        public ListCommandHandler(ParsedCommand parsedCommand) : base(parsedCommand)
        {
        }

        public override void Execute()
        {
            Console.WriteLine($"List operation with args {String.Join(' ', ParsedCommand.Args)}");
        }
    }
}
