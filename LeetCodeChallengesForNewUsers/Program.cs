using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallengesForNewUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////Roman To Integer
            //Console.WriteLine(new RomanToInt().Convert("III"));
            //Console.WriteLine();
            //Console.WriteLine(new RomanToInt().Convert("LVIII"));
            //Console.WriteLine();
            //Console.WriteLine(new RomanToInt().Convert("MCMXCIV"));
            //Console.WriteLine();
            //Console.WriteLine(new RomanToInt().Convert("CMXLIV"));

            ////Palindrome Linked List
            //List<int> list = new List<int>() { 1, 2, 3, 4 };
            //Console.WriteLine(new PalindromeLinkedList().TestPalindrome(new LinkedList<int>(list)));

            ////Ransom Note
            //Console.WriteLine(new RansomNote().CanConstruct("a", "b"));
            //Console.WriteLine();
            //Console.WriteLine(new RansomNote().CanConstruct("aab", "baa"));
            //Console.WriteLine();
            //Console.WriteLine(new RansomNote().CanConstruct("bg", "efjbdfbdgfjhhaiigfhbaejahgfbbgbjagbddfgdiaigdadhcfcj"));
            //Console.WriteLine();
            //Console.WriteLine(new RansomNote().CanConstruct("aa", "ab"));
            //Console.WriteLine();
            //Console.WriteLine(new RansomNote().CanConstruct("fihjjjjei", "hjibagacbhadfaefdjaeaebgi"));




            ////Fizz buzz            
            //foreach (var item in new FizzBuzz().Calculate(15))
            //{ 
            //    Console.WriteLine(item);
            //}

            ////Number of Steps to Reduce a Number to Zero
            //Console.WriteLine(new ReduceNumberToZero().Reduce(6));


            ////Richest Customer Wealth
            //Console.WriteLine(new RichestCustomerWealth().MaximumWealth(new int[][] { new int[] { 1, 2, 4 }, new int[] { 1, 2, 3 } }));

            ////Palindrome Number
            Console.WriteLine(new PalindromeNumber().IsPalindrome(123));
            Console.WriteLine(new PalindromeNumber().IsPalindrome(12321));






            Console.ReadKey();
        }

    }
}
