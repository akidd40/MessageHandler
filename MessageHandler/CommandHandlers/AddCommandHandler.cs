using System;

namespace MessageHandler.CommandHandlers
{
    public class AddCommandHandler : CommandHandlerBase
    {
        public AddCommandHandler(ParsedCommand parsedCommand) : base(parsedCommand)
        {
        }

        public override void Execute()
        {
            Console.WriteLine($"Add operation with args {String.Join(' ', ParsedCommand.Args)}");
        }
    }
}
