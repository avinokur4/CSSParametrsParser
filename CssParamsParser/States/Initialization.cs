using System;
using System.Collections.Generic;
using System.IO;

namespace CssParamsParser
{
    public class Initialization : IContextful, IState
    {
        public IContext Context { get; set; }

        public Initialization(IContext context)
        {
            Context = context;
        }
        
        public void Execute()
        {
            Context.ParamsList = new List<String>();
            Context.Input = String.Empty;
            
            Console.Title = "CSS Scraper";
            Console.Write("Currecnt directory: " + Directory.GetCurrentDirectory() + ">");
        }

    }
}