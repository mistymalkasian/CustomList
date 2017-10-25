using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T> : IEnumerable<T>, IComparable<T>
    {
        T[] data;
        T[] newData;
        int count;
        int capacity;

        public MyList()
        {
            capacity = 5;
            data = new T[capacity];
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        public int Capacity
        {
            get { return capacity; }
        }

        public T this[int index]
        {
            get
            {
                return data[index];

                try
                {
                    //if the index does not exist in the list
                }
                catch (Exception)
                {
                    throw new System.ArgumentException("That index does not exist in this list");
                }
            }

            set
            {
                data[index] = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)data).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return ((IEnumerable<T>)data).GetEnumerator();
        }

        int IComparable<T>.CompareTo(T other)
        {
            throw new NotImplementedException();
        }

        public bool Compare(T x, T y)
        {
            return EqualityComparer<T>.Default.Equals(x, y);
        }

        public void Add(T value)
        {
            if (count >= capacity / 2)
            {
                DoubleCapacity(data);
            }
            data[count] = value;
            count++;
        }

        private void DoubleCapacity(T[] data)
        {
            T[] newData = new T[capacity * 2];

            for (int i = 0; i < count; i++)
            {
                newData[i] = data[i];
            }
            data = newData;
        }

        public void Remove(T value)
        {
            newData = new T[capacity];

            for (int i = 0; i < count; i++)
            {
                if (Compare(data[i], (value)) == false)
                {
                    AddToNewData(data, newData);
                }
                else
                {
                    count--;
                    continue;
                }
            }
            data = newData;
        }

        private void AddToNewData(T[] data, T[] newData)
        {
         for (int j = 0; j < count; j++)
          {
             newData[j] = data[j];
          }
        }

}
}
