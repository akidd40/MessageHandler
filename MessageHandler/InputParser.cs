using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler
{
    public class InputParser
    {
        public string Input { get; }

        public InputParser(string input)
        {
            Input = input;
        }

        public ParsedCommand Parse()
        {
            string[] arr = Input.Split(' ');
            Command command = (Command) Enum.Parse(typeof(Command), arr[0]);
            string[] args = arr.Take(10).Skip(1).ToArray(); // only supports up to 9 arguments

            return new ParsedCommand(true, "ga", command, args);
        }
    }
}
