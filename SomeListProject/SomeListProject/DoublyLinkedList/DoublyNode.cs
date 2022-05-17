using System;
using System.Collections.Generic;
using System.Text;

namespace SomeListProject.DoublyLinkedList
{
    public class DoublyNode<T> 
        where T : IEquatable<T>
    {
        public T Data { get; set; }
        public DoublyNode<T> Previous { get; set; }
        public DoublyNode<T> Next { get; set; }
        public DoublyNode(T data)
        {
            Data = data;
        }

    }
}
