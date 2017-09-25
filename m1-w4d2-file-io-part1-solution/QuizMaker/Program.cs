using System;
using System.Collections.Generic;
using System.IO;

namespace QuizMaker
{
    class Program
    {

        private static List<QuizQuestion> GenerateQuestionsFromFile(string fullFilePath)
        {
            List<QuizQuestion> quizQuestions = new List<QuizQuestion>();

            try
            {
                using (StreamReader sr = new StreamReader(fullFilePath))
                {
                    // Loop through the file line-by-line, and prepare the list of questions and answers.
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        quizQuestions.Add(new QuizQuestion(line));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }

            return quizQuestions;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter the name of the file to read in for quiz questions");            
            string inputFileName = Console.ReadLine();

            string fullFilePath = Path.Combine(Environment.CurrentDirectory, inputFileName);

            while (!File.Exists(fullFilePath))            
            {
                Console.WriteLine("The file that you are requesting does not exist");
                inputFileName = Console.ReadLine();
                fullFilePath = Path.Combine(Environment.CurrentDirectory, inputFileName);
            }

            List<QuizQuestion> quizQuestions = GenerateQuestionsFromFile(fullFilePath);

            PlayGame(quizQuestions);          
        }

        private static void PlayGame(List<QuizQuestion> quizQuestions)
        {
            // Deliver the quiz by displaying the questions along with their possible answers one question at a time. Keep track
            // of the number of questions asked, and the number of correct answers.
            int numberOfQuestions = 0;
            int numberOfCorrectAnswers = 0;

            foreach (QuizQuestion quizQuestion in quizQuestions)
            {
                Console.WriteLine(quizQuestion.Question);
                for (int i = 0; i < quizQuestion.Answers.Length; i++)
                {
                    Console.WriteLine($"{i+1}) {quizQuestion.Answers[i]}");
                }

                Console.Write("\nYour answer: ");
                int answer = int.Parse(Console.ReadLine());

                if (quizQuestion.IsCorrectAnswer(answer - 1))
                {   // The correct answer index is zero-based.
                    Console.WriteLine("RIGHT!\n");
                    numberOfCorrectAnswers += 1;
                }
                else
                {
                    Console.WriteLine("WRONG!\n");
                }

                numberOfQuestions += 1;
            }
            Console.WriteLine("You got " + numberOfCorrectAnswers + " answers correct out of the total " + numberOfQuestions + " questions asked.");
        }
    }
}

