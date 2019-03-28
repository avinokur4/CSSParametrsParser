using System;

namespace CssParamsParser
{
    public class UnknownCommand : IState, IContextful
    {
        public IContext Context { get; set; }

        public UnknownCommand(IContext context)
        {
            Context = context;
        }
        
        public void Execute()
        {
            Console.WriteLine("Unknown command: " + Context.Input);
        }

    }
}