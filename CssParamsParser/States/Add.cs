using System;

namespace CssParamsParser
{
    public class Add : IState, IContextful
    {
        public IContext Context { get; set; }

        public Add(IContext context)
        {
            Context = context;
        }
        
        public void Execute()
        {
            var param = Context.Input.Substring(3, Context.Input.Length - 3);
            param = param.Trim();
            if (!String.IsNullOrEmpty(param))
            {
                Context.ParamsList.Add(param);
                Console.WriteLine("Param \"" + param + "\" was added");
            }
            else
            {
                Console.WriteLine("Param not found");
            }
        }
    }
}