using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullPath = Path.Combine(Environment.CurrentDirectory, "input.txt");

            Console.WriteLine("How many lines of text (max) should there be in the split files? ");
            string userInput = Console.ReadLine();
            int lineCount = int.Parse(userInput);

            using (StreamReader sr = new StreamReader(fullPath))
            {
                int fileNumber = 0;
                while (!sr.EndOfStream)
                {
                    string outputPath = Path.Combine(Environment.CurrentDirectory, $"input-{fileNumber}.txt");

                    using (StreamWriter sw = new StreamWriter(outputPath))
                    {
                        for (int i = 0; !sr.EndOfStream && i < lineCount; i++)
                        {                            
                            sw.WriteLine(sr.ReadLine());                            
                        }
                    }

                    fileNumber++;
                }
            }
        }
    }
}
