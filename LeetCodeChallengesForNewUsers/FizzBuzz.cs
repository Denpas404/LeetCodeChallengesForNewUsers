using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallengesForNewUsers
{
    internal class FizzBuzz
    {


        public string[] Calculate(int input)
        {
            string[] result = new string[input];

            for (int i = 1; i < input +1; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result[i-1] = "FizzBuzz";
                }
                else if (i % 3 == 0 && i % 5 != 0)
                {
                    result[i-1] = "Fizz";
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    result[i-1] = "Buzz";
                }
                else
                {
                    result[i-1] = i.ToString();
                }
            }
            return result;
        }
    }
}
