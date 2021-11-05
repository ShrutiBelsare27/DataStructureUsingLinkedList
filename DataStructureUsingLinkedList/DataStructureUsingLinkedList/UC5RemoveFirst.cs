using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureUsingLinkedList
{
    public class UC5RemoveFirst
    {
        internal Node head;

 
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
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        public void Display()
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
        public Node removeFirstNode()
        {
            if (this.head == null)
                return null;
            Node temp = head;
            head = head.next;
            return temp;
        }
    }
}
