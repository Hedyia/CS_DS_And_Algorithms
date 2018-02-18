using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //unsorted array
            int [] arr = { 9, 5, 3, 6, 5, 1, 4, 10 };

            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i+1])
                    {
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        swapped = true;
                    }
                }                

            } while (swapped);
            //sorted array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} - ",arr[i]);
            }
        }

    
    }
}
