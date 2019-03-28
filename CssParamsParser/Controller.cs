using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CssParamsParser
{
    public class Controller: IContext
    {
        public IState State{ get; set; }
        public List<string> ParamsList { get; set; }
        public String Input { get; set; }

        public Controller()
        {
            State = new Initialization(this);
            State.Execute();
            
            do
            {
                Input = Console.ReadLine();
                if (!String.IsNullOrEmpty(Input))
                {
                    Input.Trim();

                    if (Input.Equals("exit"))
                    {
                        return;
                    }
                    else if (Input.Substring(0, 3).Equals("add"))
                    {
                        State = new Add(this); 
                    }
                    else if (Input.Substring(0, 3).Equals("exe"))
                    {
                        State = new FileParse(this); 
                    }
                    else if (Input.Equals("clear"))
                    {
                        State = new Clear(this);
                    }
                    else if (Input.Equals("help"))
                    {
                        State = new Help();
                    }
                    else
                    {
                        State = new UnknownCommand(this);
                    }
                    
                    State.Execute();
                    Console.WriteLine(Environment.NewLine);
                }

            } while (true);
        }
    }
}