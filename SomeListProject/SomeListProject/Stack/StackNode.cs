using System;
using System.Collections.Generic;
using System.Text;

namespace SomeListProject.Stack
{
    public class StackNode<T> where T : IEquatable<T>
    {
        public T Data { get; set; }
        public StackNode<T> Next { get; set; }
        public StackNode(T data)
        {
            Data = data;
        }
    }
}
