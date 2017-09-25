using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Get the current directory and generate the full path
            string directory = Environment.CurrentDirectory;
            string fileName = "TestFile.txt";
            //string fileName = "TestFile.txt";
            string fullPath = Path.Combine(directory, fileName);

            // String Builder is a good way of creating a very large string in memory
            StringBuilder sb = new StringBuilder();

            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        sb.AppendLine(sr.ReadLine());
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred while reading the file");
                Console.WriteLine(e.Message);
            }

            int wordCount = GetNumberOfWordsFromString(sb.ToString());
            int sentenceCount = GetNumberOFSentencesFromString(sb.ToString());

            Console.WriteLine("The number of words is " + wordCount);
            Console.WriteLine("The number of sentences is " + sentenceCount);
        }

        private static int GetNumberOFSentencesFromString(string input)
        {
            string[] splits = input.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            
            return splits.Where(s => s != "\r\n").Count();
        }

        private static int GetNumberOfWordsFromString(string input)
        {
            // words are split by a new line and by punctuation, not just spaces
            string[] splits = input.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return splits.Length;
        }
    }
}
