using System;

namespace MessageHandler
{
    class Program
    {
        static void Main(string[] args)
        { 
            var parsedCommand1 = new InputParser("List stuff xyz").Parse();
            var parsedCommand2 = new InputParser("Add stuff gfs -bfd m").Parse();

            var commandHandler1 = CommandHandlerFactory.GetHandler(parsedCommand1);
            var commandHandler2 = CommandHandlerFactory.GetHandler(parsedCommand2);

            commandHandler1.Execute();
            commandHandler2.Execute();

            var unknownCommand = new InputParser("BLAH xyz").Parse();
            // unhandled exception thrown by line above!



        }
    }
}
