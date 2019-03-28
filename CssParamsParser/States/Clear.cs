using System;
using System.Collections.Generic;

namespace CssParamsParser
{
    public class Clear : IState, IContextful
    {
        public IContext Context { get; set; }

        public Clear(IContext context)
        {
            Context = context;
        }
        public void Execute()
        {
            Context.ParamsList = new List<String>();
            Console.WriteLine("Params list was cleared");
        }
    }
}