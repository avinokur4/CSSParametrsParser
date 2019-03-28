using System;
using System.Linq;

namespace CssParamsParser
{
    public class FileParse: IState, IContextful
    {
        public IContext Context { get; set; }

        public FileParse(IContext context)
        {
            Context = context;
        }
        
        public void Execute()
        {
            var path = Context.Input.Substring(3, Context.Input.Length - 3);
            path = path.Trim();
            if (Context.ParamsList.Any() && !String.IsNullOrEmpty(path))
            {
                var data = new CSSReader(path).getPureElements(Context.ParamsList);
                if (data.Any())
                {
                    new FileStorage().Save(data);
                }
                else
                {
                    Console.WriteLine("Nothing so save");
                }
            }
            else
            {
                Console.WriteLine("Params list is empty or file name incorrect");
            }
        }
    }
}