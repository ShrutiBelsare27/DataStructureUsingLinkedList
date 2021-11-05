using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureUsingLinkedList
{
    public class UC7SearchNode
    {

        public Node head;

   
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("inserted into the linked list", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            Console.WriteLine("Squence of linked list");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        public Node Search(int value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    Console.WriteLine("Node is present");
                    return this.head;
                }
                this.head = this.head.next;
            }
            return null;
        }
    }
}
