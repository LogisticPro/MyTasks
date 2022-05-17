using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SomeListProject.DoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
        where T : IEquatable<T>
    {
        private DoublyNode<T> _head;
        private DoublyNode<T> _tail;

        public void AddLast(T item)
        {
            if(_tail == null)
            {
                _head = _tail = new DoublyNode<T>(item);
            }
            else
            {
                var itemToAddLast = new DoublyNode<T>(item);
                _tail.Next = itemToAddLast;
                itemToAddLast.Previous = _tail;
                _tail = itemToAddLast;
            }
        }

        public void AddFirst(T item)
        {
            if(_head == null)
            {
                _tail = _head = new DoublyNode<T>(item);
            }
            else
            {
                var itemToAddFirst = new DoublyNode<T>(item);
                itemToAddFirst.Next = _head;
                _head.Previous = itemToAddFirst;
                itemToAddFirst = _head;
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
                var itemToRemove = new DoublyNode<T>(item);

                while (current != null && !current.Data.Equals(item))
                {

                    itemToRemove.Previous = current;
                    current = current.Next;
                }

                if (current == null)
                {
                    throw new Exception("Элемента нет в листе!");
                }
                else
                {
                    if (itemToRemove.Previous != null)
                    {
                        itemToRemove.Next = current.Next;
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
