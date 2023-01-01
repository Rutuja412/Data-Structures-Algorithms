﻿using System;

namespace Data_Structures_Algorithm
{
    internal class Program
    {
        private static string BalancedTextPath;

        static void Main(string[] args)
        {
            Console.WriteLine("Data Structures Algorithm");
            OrderedLinkedList orderedLinkedList = new OrderedLinkedList();
            orderedLinkedList.Ordered();
            Console.WriteLine("-------------------------------------------");
            UnorderedLinkedList unorderedLinkedList = new UnorderedLinkedList();
            unorderedLinkedList.Unordered();
            Console.WriteLine("-----------------------------------------------");
            BalancedParanthesis balancedParanthesis = new BalancedParanthesis();
            balancedParanthesis.ReadTextFile(BalancedTextPath);
            Console.WriteLine("---------------------------------------------------------------");

        }
    }
}
