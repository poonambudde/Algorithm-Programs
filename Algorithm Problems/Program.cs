using System;
using System.Collections.Generic;

namespace Algorithm_Problems
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Algorithm Programs");

            string str1 = "heart";
            string str2 = "earth";
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Both the strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams");
            }
            Console.WriteLine("Welcome to Data Sructures Algorithm Programs");

            Console.WriteLine("Enter String to find Permutation ");
            string str = Console.ReadLine();
            int n = str.Length;
            Permutations.Permutate(str, 0, n - 1);
        }
    }
}