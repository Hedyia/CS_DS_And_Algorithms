using System;

namespace Selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 1, 4, 6, 7, 5, 2 };
            for (int i = 0; i < arr.Length -1; i++)
            {
                for (int j = i+1 ; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp; 
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}, ", arr[i]);
            }
        }

        
    }
}
