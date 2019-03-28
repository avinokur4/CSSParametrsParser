using System;
using System.Collections.Generic;

namespace CssParamsParser
{
    public interface IWriter
    {
        void Save(List<String> data);
    }
}