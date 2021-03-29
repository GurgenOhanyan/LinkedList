using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList<T>
    {
      public int count;
      public ListNode<T> head;

        public LinkedList()
        {
            head = null;
            count = 0;
        }
        public void AddFirst(T value)
        {
            ListNode<T> node = new ListNode<T>(value);
            node.next=head;
            head = node;
            count++;
        }
        public void Add(T value) 
        {
            ListNode<T> node = new ListNode<T>(value);
            ListNode<T> node1=head;
            while (node1.next != null)
            {
                node1 = node1.next;
            }
            node1.next = node;
            count++;
        }
        public void RemoveAt(int index)
        {
            ListNode<T> node = head;
            if (index == 1)
            {
                head = node.next;
                count--;
                return;
            }
            for (int i = 1; i < index - 1; i++)
            {
                node = node.next;
            }
            node.next = node.next.next;
            count--;
        }
        public ListNode<T> FindNode(T value)
        {
            ListNode<T> node = head;
            ListNode<T> result = null;
            while (node != null)
            {
                if (node.value.Equals(value))
                {
                    result = node;
                    result.next.next= null;
                    break;
                }
                node = node.next;
            
            }
            if (result == null)
            {
                Console.WriteLine("not find");
            }
            return result;
        }

        public int Count()
        {
            return count;
        }       
    }
}
