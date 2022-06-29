using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallengesForNewUsers
{
    internal class RichestCustomerWealth
    {
        public int MaximumWealth(int[][] accounts)
        {
            int[] wealth = new int[accounts.Length];
            for (int i = 0; i < accounts.Length; i++)
            {
                wealth[i] = accounts[i].Sum();
            }
            Array.Sort(wealth);
            Array.Reverse(wealth);

            return wealth[0];
        }
    }
}
