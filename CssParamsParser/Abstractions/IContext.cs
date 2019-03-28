using System;
using System.Collections.Generic;

namespace CssParamsParser
{
    public interface IContext
    {
        IState State{ get; set; }
        
        List<String> ParamsList{ get; set; }

        String Input { get; set; }
    }
}