using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Problems
{
    class Permutations
    {
        // Recursive function to generate all permutations of a string
        public static void Permutate(string str, int start, int end)
        {
            if (start == end)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    str = (Swap(str, start, i));
                    Permutate(str, start + 1, end);
                    str = Swap(str, start, i);
                }
            }

        }

        //swap two characters in a character array
        public static string Swap(string word, int start, int end)
        {
            char temp;
            char[] charArray = word.ToCharArray();
            temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}