using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallengesForNewUsers
{
    internal class ReduceNumberToZero
    {
        public int Reduce(int num)
        { 
            int counter = 0;

            while (num != 0 )
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                    counter++;
                }
                else
                {
                    num -= 1;
                    counter++;
                }
            }
            return counter;
        }  

    }
}
