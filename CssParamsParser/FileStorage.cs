using System;
using System.Collections.Generic;
using System.IO;

namespace CssParamsParser
{
    public class FileStorage : IReader, IWriter
    {
        public List<String> Read(String filePath)
        {
            if (File.Exists(filePath))
            {
                List<String> result = new List<String>();
                
                using (StreamReader sr = File.OpenText(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        result.Add(line);
                    }
                }
                Console.WriteLine("File return data");
                return result;
            }
            else
            {
                Console.WriteLine("File not found");
                return new List<String>();
            } 
        }
        
        public void Save(List<String> data)
        {
            var directory = Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/CSS_FileStorage");
            var fileName = directory.FullName + "/" + DateTime.Now.ToLongDateString() + DateTime.Now.ToShortTimeString() + ".css";
            using (StreamWriter sr = File.CreateText(fileName))
            {
                foreach (var line in data)
                {
                    sr.WriteLine(line);
                }
            }
            Console.WriteLine("Saved to " + fileName);
        }
    }
}