using System;
using System.Collections.Generic;
using System.Text;

namespace SomeListProject.Queue
{
    public class QueueNode<T> where T : IEquatable<T>
    {
        public T Data { get; set; }
        public QueueNode<T> Previous { get; set; }
        public QueueNode(T data)
        {
            Data = data;
        }
    }
}
