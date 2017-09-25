using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public class QuizQuestion
    {
        private const char Delimiter = '|';


        private string question;
        public string Question
        {
            get { return question; }
        }

        private List<string> answers = new List<string>();
        public string[] Answers
        {
            get { return answers.ToArray(); }
        }

        private int correctAnswer;

       
        /// <summary>
        /// Creates a new instance of a quiz question from a pipe-delimited input string
        /// </summary>
        /// <param name="line"></param>
        public QuizQuestion(string line)
        {
            if (!String.IsNullOrEmpty(line))
            {
                string[] parts = line.Split(Delimiter);

                this.question = parts[0];

                for (int i = 1; i < parts.Length; i++)
                {
                    string answer = parts[i].Trim(); //trim off whitespace

                    if (answer.EndsWith("*"))
                    {
                        answer = answer.Substring(0, answer.Length - 1); //strip out the *
                        this.correctAnswer = i - 1; // correct answer is zero based
                    }

                    answers.Add(answer);
                }
            }
        }



        /// <summary>
        /// Determines if the answer provided is the correct answer.
        /// </summary>
        /// <param name="selectedAnswer"></param>
        /// <returns></returns>
        public bool IsCorrectAnswer(int selectedAnswer)
        {
            return this.correctAnswer == selectedAnswer;
        }

    }
}
