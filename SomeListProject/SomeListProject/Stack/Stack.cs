using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SomeListProject.Stack
{
    public class Stack<T> where T : IEquatable<T>
    {
        private StackNode<T> _head;

        public void Push(T item)
        {
            if (_head == null)
            {
                _head = new StackNode<T>(item);
            }
            else
            {
                var itemToAdd = new StackNode<T>(item);
                itemToAdd.Next = _head;
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
                var current = _head;

                if (_head.Next != null)
                {
                    _head = _head.Next;                  
                }
                else
                {
                    _head = null;
                }

                return current.Data;
            }
        }
    }
}
