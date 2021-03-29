using System;
using System.Collections.Generic;
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> mylist = new LinkedList<int>();
            mylist.AddFirst(18);
            mylist.AddFirst(28);
            mylist.AddFirst(38);
            mylist.AddFirst(48);
            mylist.AddFirst(58);
            mylist.Add(100);
            mylist.AddFirst(68);
            mylist.Add(200);
            mylist.AddFirst(78);
            mylist.RemoveAt(4);
            ListNode<int> findResult = mylist.FindNode(48);
            //ListNode<int> nodeIterator = mylist.head;
            //while (nodeIterator != null)
            //{
            //    Console.Write(nodeIterator.value + "  ");
            //    nodeIterator = nodeIterator.next;
            //}
            Console.WriteLine(findResult);

            Console.WriteLine(mylist.Count());
            Console.ReadKey();
        }

        
    }
}
