using System;
using System.Collections.Generic;

namespace CssParamsParser
{
    public interface IReader
    {
        List<String> Read(String filePath);
    }
}