using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_Session2_Assignment
{
    internal class FixedSizeList<T>
    {
        public int Capacity { get; }
        private T[] Values;
        private int currentSize;

        public FixedSizeList(int _Capacity)
        {
            if (_Capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.");
            }
            Capacity = _Capacity;
            Values = new T[Capacity];
            currentSize = 0;
        }

        public void Add(T Value)
        {
            if (currentSize >= Capacity)
            {
                throw new InvalidOperationException("Cannot add more elements. The list is full.");
            }
            Values[currentSize] = Value;
            currentSize++;
        }

        public T Get(int Index)
        {
            if (Index < 0 || Index >= currentSize)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }
            return Values[Index];
        }

        public int Count
        {
            get { return currentSize; }
        }
    }
}
