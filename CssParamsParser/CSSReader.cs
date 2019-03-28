using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CssParamsParser
{
    public class CSSReader
    {
        //Sould you use Array<> to optimize
        private List<String> _inputTextList;

        public CSSReader(String filePath)
        {
            _inputTextList = new FileStorage().Read(filePath);
        }

        private List<List<String>> getAllBlocks()
        {
            List<List<String>> result = new List<List<string>>();

            for(int index = 0, length = _inputTextList.Count; index < length; index++)
            {
                List<String> block = new List<String>();
                if (_inputTextList[index].Contains('{'))
                {
                    do
                    {
                        block.Add(_inputTextList[index]);

                        index++;
                    } while (!_inputTextList[index].Contains('}'));

                    block.Add(_inputTextList[index]);
                    result.Add(block);
                }
            }
            
            Console.WriteLine(result.Count + " blocks was found");
            
            return result;
        }

        public List<String> getPureElements(List<String> paramNames)
        {
            var blocks = getAllBlocks();
            List<String> result = new List<String>();
            if (blocks.Count > 0)
            {
                foreach (var block in blocks)
                {
                    String addBlockParams = String.Empty;
                    foreach (var line in block)
                    {
                        foreach (var param in paramNames)
                        {
                            if (line.Contains(param))
                            {
                                addBlockParams += line;
                                addBlockParams += Environment.NewLine;
                                break;
                            }
                        }
                    }

                    if (!String.IsNullOrEmpty(addBlockParams))
                    {
                        result.Add(block[0]);
                        result.Add(addBlockParams);
                        result.Add(block[block.Count - 1]);
                    }

                }

                Console.WriteLine("File data");
                Console.WriteLine("=============================================================================");
                result.ForEach(_ => Console.WriteLine(_));
                Console.WriteLine("=============================================================================");
                Console.WriteLine("End of file");
            }

            return result;
        }
    }
}