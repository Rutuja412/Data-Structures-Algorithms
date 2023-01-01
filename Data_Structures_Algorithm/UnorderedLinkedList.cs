using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_Algorithm
{
    internal class UnorderedLinkedList
    {
        public void Unordered()
        {
            LinkedList<string> List = new LinkedList<string>();
            string text = "This is Unordered List";
            string[] list = text.Split(" ");
            int count = 0;
            while (count < list.Length)
            {
                List.Add(list[count++]);
            }
            List.Display();
            Console.WriteLine("\n");
            List.Search("List");
        }
    }
}
