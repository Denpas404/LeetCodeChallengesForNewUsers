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
            bool ja = false;

            for (int i = 0; i < ransom.Count; i++)
            {
                c = ransom.ElementAt(i).Key;

                Console.WriteLine("ransom: " + ransom.ElementAt(i).Key);
                Console.WriteLine("Maga: " + magazineDict.ElementAt(i).Key);
                Console.WriteLine("ransom: " + ransom.ElementAt(i).Value);
                Console.WriteLine("Maga: " + magazineDict.ElementAt(i).Value);

                if (ransom.ElementAt(i).Key == magazineDict.ElementAt(i).Key && ransom.ElementAt(i).Value <= magazineDict.ElementAt(i).Value)
                {
                    ja = true;
                }
                else
                {
                    ja = false;
                }
            }



            //Udskriver dictionary
            //ransom.ToList().ForEach(x => Console.WriteLine(x.Key + " " +  x.Value));
            //Console.WriteLine("--");
            //magazineDict.ToList().ForEach(x => Console.WriteLine(x.Key + " " + x.Value));

            return ja;



           // return magazine.Contains(ransomNote);

        }
    }
}
