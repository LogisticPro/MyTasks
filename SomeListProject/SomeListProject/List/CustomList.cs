using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SomeListProject.List
{
    public class CustomList<T> : IList<T> 
    {
        private T[] _array;
        private const int _startCapacity = 5;

        public T this[int index]
        { 
            get => _array[index];

            set => _array[index] = value; 
        }

        public int Capacity { get; private set; } = _startCapacity;
        public int Count { get; private set; } = 0;

        public bool IsReadOnly => false;

        public CustomList()
        {
           _array = new T[Capacity];
        }

        public void Add(T item)
        {
            if(Count == Capacity)
            {
                ArrayIncrease();
            }

            _array[Count] = item;
            Count++;
        }      

        public void Clear()
        {
            Capacity = _startCapacity;
            _array = new T[Capacity];
        }

        public bool Contains(T item)
        {
            foreach (var elem in _array)
            {
                if (elem.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                array[i + arrayIndex] = _array[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < Count; i++)
            {
                yield return _array[i];
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (item.Equals(_array[i]))
                {
                    return i;
                }
            }

            throw new ArgumentException("Такого элемента нет!");
        }

        public void Insert(int index, T item)
        {
            if (index > Count)
            {
                throw new ArgumentOutOfRangeException($"Элемент невозможно вставить по индексу с номером {index}");
            }
            else
            {
                if (Count == Capacity)
                {
                    ArrayIncrease();
                }

                for(int i = Count; i > index; i--)
                {
                    _array[i] = _array[i - 1];
                }

                _array[index] = item;
            }

            Count++;
        }

        public bool Remove(T item)
        {
            var index = IndexOf(item);

            if (index == -1) return false;

            RemoveAt(index);

            return true;
        }

        public void RemoveAt(int index)
        {
            if(index > Count || index < 0)
            {
                throw new ArgumentOutOfRangeException($"Элемент невозможно удалить по индексу с номером {index}");
            }
                
            for (int i = index; i < Count - 1; i++)
            {
                _array[i] = _array[i + 1];
            }

            Count--;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void ArrayIncrease()
        {
            Capacity *= 2;
            var newArray = new T[Capacity];
            _array.CopyTo(newArray, 0);
            _array = newArray;
        }
    }
}
