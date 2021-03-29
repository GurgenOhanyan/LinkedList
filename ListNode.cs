using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class ListNode<T>
    {
        public T  value;
        public ListNode<T> next;
        public ListNode(T result)
        {
            this.value = result;
            next = null;
        }
        public override string ToString()
        {
            return $"{this.value}=>{this.next}";
        }
    }
}
