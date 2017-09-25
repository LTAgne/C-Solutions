using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataNumbersToWords
    {
        
        private string[] numNames = {
            "",
            " one",
            " two",
            " three",
            " four",
            " five",
            " six",
            " seven",
            " eight",
            " nine",
            " ten",
            " eleven",
            " twelve",
            " thirteen",
            " fourteen",
            " fifteen",
            " sixteen",
            " seventeen",
            " eighteen",
            " nineteen"
        };

        private string[] tensNames = {
            "",
            " ten",
            " twenty",
            " thirty",
            " forty",
            " fifty",
            " sixty",
            " seventy",
            " eighty",
            " ninety"
        };

        private string[] specialNames = {
            "",
            " thousand",
            " million"
        };

        private String NumberToWordsLessThanOneThousand(int number)
        {
            // Handle numbers less than 1000
            string words = "";
            if (number % 100 < 20)
            {
                words = numNames[number % 100];
                number /= 100;
            }
            else
            {
                words = numNames[number % 10];
                number /= 10;
                words = tensNames[number % 10] + words;
                number /= 10;
            }
            if (number == 0)
            {
                return words;
            }
            return numNames[number] + " hundred" + words;
        }

        public string NumberToWords(int number)
        {
            if (number == 0) { return "zero"; }
            string prefix = "";
            if (number < 0)
            {
                number = -number;
                prefix = "negative";
            }
            string current = "";
            int place = 0;
            do
            {
                int n = number % 1000;
                if (n != 0)
                {
                    string s = NumberToWordsLessThanOneThousand(n);
                    current = s + specialNames[place] + current;
                }
                place++;
                number /= 1000;
            } while (number > 0);
            return (prefix + current).Trim();
        }

        public int WordsToNumber(string words)
        {
            int number = 0;
            int finalNumber = 0;
            string[] valueWords = words.ToLower().Split(' ');
            foreach (string str in valueWords)
            {
                if (str.Equals("zero"))
                {
                    number += 0;
                }
                else if (str.Equals("one"))
                {
                    number += 1;
                }
                else if (str.Equals("two"))
                {
                    number += 2;
                }
                else if (str.Equals("three"))
                {
                    number += 3;
                }
                else if (str.Equals("four"))
                {
                    number += 4;
                }
                else if (str.Equals("five"))
                {
                    number += 5;
                }
                else if (str.Equals("six"))
                {
                    number += 6;
                }
                else if (str.Equals("seven"))
                {
                    number += 7;
                }
                else if (str.Equals("eight"))
                {
                    number += 8;
                }
                else if (str.Equals("nine"))
                {
                    number += 9;
                }
                else if (str.Equals("ten"))
                {
                    number += 10;
                }
                else if (str.Equals("eleven"))
                {
                    number += 11;
                }
                else if (str.Equals("twelve"))
                {
                    number += 12;
                }
                else if (str.Equals("thirteen"))
                {
                    number += 13;
                }
                else if (str.Equals("fourteen"))
                {
                    number += 14;
                }
                else if (str.Equals("fifteen"))
                {
                    number += 15;
                }
                else if (str.Equals("sixteen"))
                {
                    number += 16;
                }
                else if (str.Equals("seventeen"))
                {
                    number += 17;
                }
                else if (str.Equals("eighteen"))
                {
                    number += 18;
                }
                else if (str.Equals("nineteen"))
                {
                    number += 19;
                }
                else if (str.Equals("twenty"))
                {
                    number += 20;
                }
                else if (str.Equals("thirty"))
                {
                    number += 30;
                }
                else if (str.Equals("forty"))
                {
                    number += 40;
                }
                else if (str.Equals("fifty"))
                {
                    number += 50;
                }
                else if (str.Equals("sixty"))
                {
                    number += 60;
                }
                else if (str.Equals("seventy"))
                {
                    number += 70;
                }
                else if (str.Equals("eighty"))
                {
                    number += 80;
                }
                else if (str.Equals("ninety"))
                {
                    number += 90;
                }
                else if (str.Equals("hundred"))
                {
                    number *= 100;
                }
                else if (str.Equals("thousand"))
                {
                    number *= 1000;
                    finalNumber += number;
                    number = 0;
                }
                else if (str.Equals("million"))
                {
                    number *= 1000000;
                    finalNumber += number;
                    number = 0;
                }
            }
            finalNumber += number;
            return finalNumber;
        }
    }
}
