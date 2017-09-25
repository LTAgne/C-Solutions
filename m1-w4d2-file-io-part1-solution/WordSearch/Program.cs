using System;
using System.IO;

namespace WordSearch
{
    class Program
    {
        private const int APPLICATION_FAILURE_EXIT_CODE = 1;

        // WordCount parameters
        private static String searchWord;
        private static String inputFileName;
        private static bool ignoreCase = false; // By default case is not ignored.

        static void Main(string[] args)
        {
            Console.WriteLine("What is the file that should be searched?");
            string inputFileName = Console.ReadLine();

            Console.WriteLine("What is the search word you are looking for? ");
            string searchWord = Console.ReadLine();

            Console.WriteLine("Should the search be case sensitive? (Y\\N)");
            bool caseSensitive = (Console.ReadLine().ToLower() == "y");

            

            // Open and search the file
            string directory = Environment.CurrentDirectory;
            string inputFullPath = Path.Combine(directory, inputFileName);

            try
            {
                using (StreamReader sr = new StreamReader(inputFullPath))
                {
                    int i = 1;
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        bool lineContainsWord = (!caseSensitive && line.IndexOf(searchWord, StringComparison.CurrentCultureIgnoreCase) > 0) || 
                            line.IndexOf(searchWord) > 0;

                        if (lineContainsWord)
                        {
                            Console.WriteLine($"{i}) {line}");
                        }

                        i++;
                    }                  
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
                Environment.Exit(APPLICATION_FAILURE_EXIT_CODE);
            }

        }
    }
}
