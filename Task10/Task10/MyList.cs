using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task10
{
    class MyList : IList<MyItem>
    {
        readonly List<MyItem> List = new List<MyItem>();

        public MyItem this[int index] { get => List[index]; set => List[index] = value; }

        public int Count => List.Count;

        public bool IsReadOnly => ((IList<MyItem>)List).IsReadOnly;

        public void Add(MyItem item)
        {
            List.Add(item);
        }

        public void Clear()
        {
            List.Clear();
        }

        public bool Contains(MyItem item)
        {
            return List.Contains(item);
        }

        public void CopyTo(MyItem[] array, int arrayIndex)
        {
            List.CopyTo(array, arrayIndex);
        }

        public IEnumerator<MyItem> GetEnumerator()
        {
            return ((IList<MyItem>)List).GetEnumerator();
        }

        public int IndexOf(MyItem item)
        {
            return List.IndexOf(item);
        }

        public void Insert(int index, MyItem item)
        {
            List.Insert(index, item);
        }

        public bool Remove(MyItem item)
        {
            return List.Remove(item);
        }

        public void RemoveAt(int index)
        {
            List.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IList<MyItem>)List).GetEnumerator();
        }
    }
}
