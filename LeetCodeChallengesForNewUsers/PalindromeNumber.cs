using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallengesForNewUsers
{
    internal class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            int[] result = x.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            int[] cwResult = new int[result.Length];
            int y;

            for (int i = 0; i < result.Length; i++)
            {
                cwResult[i] = result[i];
            }

            Array.Reverse(cwResult);

            Int32.TryParse(string.Join("", cwResult), out y);
            
            return x.Equals(y);
        }
    }
}
