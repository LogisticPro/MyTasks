using System;
using System.Collections.Generic;
using System.Text;

namespace SomeListProject.Queue
{
    public class Queue<T> where T : IEquatable<T>
    {
        private QueueNode<T> _head;
        private QueueNode<T> _tail;

        public void Push(T item)
        {
            if (_head == null)
            {
                _head = _tail = new QueueNode<T>(item);
            }
            else
            {
                var itemToAdd = new QueueNode<T>(item);
                _head.Previous = itemToAdd;
                _head = itemToAdd;
            }
        }

        public T Pop()
        {
            if (_head == null)
            {
                throw new Exception("Элементов нет в листе!");
            }
            else
            {
                var current = _tail;

                if (_tail != null)
                {
                    _tail.Previous = _tail;
                }
                else
                {
                    _tail = null;
                }

                return current.Data;
            }
        }
    }
}
