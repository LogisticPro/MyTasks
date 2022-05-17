using System;
using System.Collections.Generic;
using System.Text;

namespace SomeListProject
{
    public class Node<T>
        where T : IEquatable<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T data)
        {
            Data = data;
        }
    }
}
