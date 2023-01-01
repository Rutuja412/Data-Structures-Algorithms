using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_Algorithm
{
    internal class OrderedLinkedList
    {
        public void Ordered()
        {
            LinkedList<int> List = new LinkedList<int>();
            int[] arr = { 8, 9, 5, 0, 3, 6 };
            Array.Sort(arr);
            foreach (var number in arr)
            {
                Console.WriteLine(number);
            }
            List.Display();
            List.Search(8);
        }
    }
}
