﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_Algorithm
{
    public class LinkedList<T>
    {
        public Node<T> head;
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} : word add in list", node.data);
        }
        public void Search(T value)
        {
            Node<T> temp = this.head;
            while (temp != null)
            {
                if (temp.data.Equals(value))
                {
                    Console.WriteLine(" {0}: is found ", temp.data);
                    return;
                }
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("{0}: word is not found");
                Add(value);
            }
        }
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("No word in Linked List");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
