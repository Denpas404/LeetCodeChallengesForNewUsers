using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallengesForNewUsers
{
    internal class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var ransom = new Dictionary<char, int>(); 
            char[] charsRansom = ransomNote.ToCharArray();
            Array.Sort(charsRansom);
            char c = ' ';

            for (int i = 0; i < charsRansom.Length; i++)
            {
                c = charsRansom[i];

                if (!ransom.ContainsKey(c))
                {
                    ransom.Add(c, 1);
                }
                else
                {
                    ransom[c]++;
                }
            }

            for (int i = 0; i < magazine.Length; i++)
            {
                c = magazine[i];

                if (ransom.ContainsKey(c))
                {
                    ransom[c]--;
                }
            }

            for (int i = 0; i < ransom.Count; i++)
            {
                if (ransom.ElementAt(i).Value > 0)
                {
                    return false;
                }
                
            }
            return true;              
        }
    }
}