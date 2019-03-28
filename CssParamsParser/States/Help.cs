using System;

namespace CssParamsParser
{
    public class Help : IState
    {
        public void Execute()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("    help - help reference");
            Console.WriteLine("    exit - quit app");
            Console.WriteLine("    add - add [param_name]");
            Console.WriteLine("    clear - clear param");
            Console.WriteLine("    exe - exe [short file name or full file name]");
        }
    }
}