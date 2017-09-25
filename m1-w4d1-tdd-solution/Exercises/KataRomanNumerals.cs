using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataRomanNumerals
    {

        private string[] thousandRoman = new String[] { "", "M", "MM", "MMM" };
        private string[] hundredRoman = new String[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        private string[] tenRoman = new String[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        private string[] oneRoman = new String[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        public string ArabicToRoman(int arabicNum)
        {
            string romanNum = "";
            if (arabicNum < 4000)
            {
                romanNum += thousandRoman[arabicNum / 1000];
                arabicNum %= 1000;
                romanNum += hundredRoman[arabicNum / 100];
                arabicNum %= 100;
                romanNum += tenRoman[arabicNum / 10];
                arabicNum %= 10;
                romanNum += oneRoman[arabicNum];
            }
            return romanNum;
        }

        // Step 2: Write a function to convert in the other direction from Roman Numeral to digit.
        public int RomanToArabic(String str)
        {
            Dictionary<char, int> romanMap = new Dictionary<char, int>();
            romanMap.Add('I', 1);
            romanMap.Add('V', 5);
            romanMap.Add('X', 10);
            romanMap.Add('L', 50);
            romanMap.Add('C', 100);
            romanMap.Add('D', 500);
            romanMap.Add('M', 1000);

            int arabicNum = 0;
            char lastCharKey = 'M';
            for (int i = 0; i < str.Length; i++)
            {
                char charKey = str[i];
                arabicNum += romanMap[charKey];
                if (romanMap[lastCharKey] < romanMap[charKey])
                {
                    arabicNum -= 2 * romanMap[lastCharKey];
                }
                lastCharKey = charKey;
            }
            return arabicNum;
        }
    }
}
