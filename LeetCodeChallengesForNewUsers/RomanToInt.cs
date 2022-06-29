using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallengesForNewUsers
{
    internal class RomanToInt
    {
        //13. Roman to Integer

        /*
        I             1
        V             5
        X             10
        L             50
        C             100
        D             500
        M             1000
        */

        public int Convert(string input)
        {
            int sum = 0; //Samlet sum af romertal            

            var roman = new Dictionary<char, int>(); //Dictionary, romertal som key og romertal værdig som value.

            roman.Add('I', 1);
            roman.Add('V', 5);
            roman.Add('X', 10);
            roman.Add('L', 50);
            roman.Add('C', 100);
            roman.Add('D', 500);
            roman.Add('M', 1000);

            char[] chars = input.ToCharArray(); //Input fra bruger til char array

            for (int i = 0; i < chars.Length; i++)
            {
                if (i + 1 < chars.Length && roman[chars[i + 1]] > roman[chars[i]])
                {
                    sum -= roman[chars[i]];
                }
                else
                {
                    sum += roman[chars[i]];
                }
            }            
            return sum;
        }

    }
}
