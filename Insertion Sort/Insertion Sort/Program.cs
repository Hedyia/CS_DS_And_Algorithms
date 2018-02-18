using System;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unsorted array
            int[] arr = { 3, 1, 4, 6, 7, 5, 2 };

            for (int i = 1; i < arr.Length; i++)
            {
                int value = arr[i];
                int hole = i;
                while (hole > 0  && value < arr[hole-1])
                {
                    arr[hole] = arr[hole - 1];
                    hole--;
                }
                arr[hole] = value;
            }

            //sorted array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}, ", arr[i]);
            }
        }
    }
}
