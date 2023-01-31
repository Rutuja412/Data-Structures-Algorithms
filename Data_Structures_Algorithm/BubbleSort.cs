using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_Algorithm
{
    public class BubbleSort
    {
        public void Sort(int[] arr)
        {
            // int[] arr2 = { 5, 2, 1, 4, 3 };
            for (int i = 0; i < arr.Length - 1; i++)// traversing 5 times
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (var data in arr)
            {
                Console.WriteLine(data);
            }
        }
    }
}
