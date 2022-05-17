using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SomeListProject
{
    public class LinkedList<T> : IEnumerable<T>
        where T : IEquatable<T>
    {
        private Node<T> _head;
        private Node<T> _tail;

        public void AddLast(T item)
        {
            if(_tail == null)
            {
                _head = _tail = new Node<T>(item);
            }
            else
            {
                var itemToAddLast = new Node<T>(item);
                _tail.Next = itemToAddLast;
                _tail = itemToAddLast;
            }
        }

        public void AddFirst(T item)
        {
            if(_head == null)
            {
                _head = _tail = new Node<T>(item);
            }
            else
            { 
                var itemToAddFirst = new Node<T>(item);
                itemToAddFirst.Next = _head;
                _head = itemToAddFirst;
            }
        }

        public void Remove(T item)
        {
            if (_head == null)
            {
                throw new Exception("Элементов нет в листе!");
            }
            else
            {
                var current = _head;
                Node<T> previous = null;

                while(current != null && !current.Data.Equals(item))
                {
                    previous = current;
                    current = current.Next;
                }
                
                if(current == null)
                {
                    throw new Exception("Элемента нет в листе!");
                }
                else
                {
                    if(previous != null)
                    {
                        previous.Next = current.Next;
                    }
                    else
                    {
                        _head = current.Next;
                    }                  
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
