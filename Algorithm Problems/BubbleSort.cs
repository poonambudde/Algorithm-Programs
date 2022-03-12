using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Problems
{
    class BubbleSort
    {
        public void Bubble_Sort()
        {
            int[] intArray = new int[5];
            Console.WriteLine("Enter the Array Elements : ");
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }
            //Sorting the array
            for (int j = 0; j <= intArray.Length - 2; j++)
            {
                for (int i = 0; i <= intArray.Length - 2; i++)
                {
                    if (intArray[i] > intArray[i + 1])
                    {
                        int temp = intArray[i + 1];
                        intArray[i + 1] = intArray[i];
                        intArray[i] = temp;
                    }
                }
            }
            Console.WriteLine("After Sorting Array Sorted order is :");
            foreach (int item in intArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
