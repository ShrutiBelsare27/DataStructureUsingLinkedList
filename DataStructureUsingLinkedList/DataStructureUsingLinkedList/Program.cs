using System;

namespace DataStructureUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Data structure program using Linked List");
            Console.WriteLine("\n UC1");
            UC1LinkedList linkedList = new UC1LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();

            Console.WriteLine("\n UC2");
          UC2LinkedList linkedList1 = new UC2LinkedList();
            linkedList1.Add2(70);
            linkedList1.Add2(30);
            linkedList1.Add2(56);
            linkedList.Display();

            Console.WriteLine("\n UC3");
            UC3LinkedList linkedList2 = new UC3LinkedList();
            linkedList2.Append(56);
            linkedList2.Append(30);
            linkedList2.Append(70);
            linkedList.Display();


            Console.WriteLine("\n UC4");
            UC4InsertAfter linkedList3 = new UC4InsertAfter();
            linkedList3.Add(56);
            linkedList3.Add(70);
            //linkedList.Display();
           
            linkedList3.InsertAtParticularPoistion(2, 30);
            linkedList3.Display();


            Console.WriteLine("\n UC5");
            UC5RemoveFirst remove = new UC5RemoveFirst();
            remove.Add(56);
            remove.Add(30);
            remove.Add(70);
            remove.Display();
            Console.WriteLine("First element is poped out from linked list = " + remove.removeFirstNode().data);
            remove.Display();


            Console.WriteLine("\n UC6");
            UC6LastRemove rm = new UC6LastRemove();
            rm.Add(56);
            rm.Add(30);
            rm.Add(70);
            rm.Display();
            Console.WriteLine("last element is poped out from linked list = " + rm.removeLastNode().data);
            rm.Display();


               Console.WriteLine("UC7");
               UC7SearchNode sn = new UC7SearchNode();
               sn.Add(56);
               sn.Add(30);
               sn.Add(70);
               sn.Display();
               Console.WriteLine("Serach node: " + sn.Search(30).data);
            

            Console.WriteLine("\n UC8");
            UC8 obj = new UC8();
            obj.Add(56);
            obj.Add(30);
            obj.Add(70);
            //linkedList.Display();

            obj.AddInBet2(obj.head.next,40);
            obj.Display();
           
            Console.WriteLine("\n UC9");
            UC9 obj1 = new UC9();
            obj1.Add(56);
            obj1.Add(30);
            obj1.Add(40);
            obj1.Add(70);
            obj1.Display();
            obj1.deleteNode(40);
            obj1.Display();
            Console.WriteLine("size is: " + obj1.size());


            Console.WriteLine("\n UC10");
            UC10 sort = new UC10();
            sort.Add(56);
            sort.Add(30);
            sort.Add(40);
            sort.Add(70);
            sort.Display();
        }
    }
}
