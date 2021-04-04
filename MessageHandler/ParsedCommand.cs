namespace MessageHandler
{
    public class ParsedCommand
    {
        public bool IsSuccess { get; }
        public string Prefix { get; }
        public Command Command { get; }
        public string[] Args { get; }
        public ParsedCommand(bool isSuccess, string prefix, Command command, string[] args)
        {
            IsSuccess = isSuccess;
            Prefix = prefix;
            Command = command;
            Args = args;
        }
    }
}
