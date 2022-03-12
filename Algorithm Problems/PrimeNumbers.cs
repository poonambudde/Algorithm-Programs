using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Problems
{
    class PrimeNumbers
    {
        public void Prime()
        {
            bool isPrime = true;
            Console.WriteLine("Prime Numbers Between 0 To 1000 :- ");
            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 2; j <= 1000; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
                isPrime = true;
            }
        }
    }
}
