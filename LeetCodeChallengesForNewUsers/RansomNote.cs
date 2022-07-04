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
            var ransom = new Dictionary<char, int>(); //Dictionary, romertal som key og romertal værdig som value.
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

            var magazineDict = new Dictionary<char, int>();
            char[] charsMagazine = magazine.ToCharArray();
            Array.Sort (charsMagazine);

            for (int j = 0; j < charsMagazine.Length; j++)
            {
                c = charsMagazine[j];

                if (!magazineDict.ContainsKey(c))
                {
                    magazineDict.Add(c, 1);
                }
                else
                {
                    magazineDict[c]++;
                }
            }

            if (ransom.Count <= magazineDict.Count)
            {
                for (int i = 0; i < ransom.Count; i++)
                {
                    if (magazineDict.ContainsKey(ransom.ElementAt(i).Key))
                    {
                        if (ransom.ElementAt(i).Value <= magazineDict.ElementAt(i).Value)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return false;   
                    }
                }
            }
            else
            {
                return false;
            }

            return false;           
        }
    }
}
