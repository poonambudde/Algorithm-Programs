using System;

namespace Algorithm_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Sructures Algorithm Programs");

            Console.WriteLine("Enter String to find Permutation ");
            string str = Console.ReadLine();
            int n = str.Length;
            Permutations.Permutate(str, 0, n - 1);
        }
    }
}