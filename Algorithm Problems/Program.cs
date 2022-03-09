using System;
using System.Collections.Generic;

namespace Algorithm_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs");

            List<string> list = new List<string>();
            int n;
            Console.WriteLine("Enter the size of list");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter words in the list");
            for (int k = 0; k < n; k++)
            {
                list.Add(Console.ReadLine());
            }
            Console.WriteLine("Plz Enter the word that has to be searched");
            string word = Console.ReadLine();
            list.Sort();
            int i = 0, j = n - 1;
            bool found = false;
            while (i <= j)
            {
                int mid = (i + j) / 2;
                if (list[mid].CompareTo(word) == 0)
                {
                    found = true;
                    break;
                }
                else if (list[mid].CompareTo(word) < 0)
                    i = mid + 1;
                else
                    j = mid - 1;
            }
            if (found == true)
                Console.WriteLine("Word is Found");
            else
                Console.WriteLine("Word is not found");
        }
    }
}