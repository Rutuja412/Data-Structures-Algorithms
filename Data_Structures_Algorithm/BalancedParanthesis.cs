using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data_Structures_Algorithm
{
    internal class BalancedParanthesis
    {
        public void ReadTextFile(string filepath)
        {

            string list = File.ReadAllText(@"E:\RFP 232 BATCH\Data-Structures-Algorithms\Data_Structures_Algorithm\Balanced.txt");
            string[] words = list.Split(" ");
            LinkedListStack<string> LinkedListstack = new LinkedListStack<string>();
            foreach (var data in words)
            {
                if (data.Equals("("))
                    LinkedListstack.Push(data);
                if (data.Equals(")"))
                    LinkedListstack.Pop();
            }
            if (LinkedListstack.Peek())
            {
                Console.WriteLine("Arithmatic Expression is balanced");
            }
            else
                Console.WriteLine("Arithmatic Expression is not balanced");
        }
    }
}
