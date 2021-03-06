using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureUsingLinkedList
{
    public class UC3LinkedList
    {
        internal Node head;
        public void Append(int data)
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
                /*node.next = head;
                this.head = node*/;
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
    }
}
