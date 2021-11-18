using System;
using System.Collections.Generic;
using System.Text;

namespace Task9
{
    public class MyCollection <T> : IIndexatorable, IAddable, ICreatorable where T : Vechicle
    {
        public T [] arrayOfElements = new T [10];

        public int ElementNumber { get; set; }

        public int Count { get => ElementNumber; }

        public void GetValue(int index)
        {
            arrayOfElements[index].GetInfo();
        }

        public void Add(T item)
        {
            arrayOfElements[ElementNumber] = item;
            ElementNumber++;
        }      
    }
}
