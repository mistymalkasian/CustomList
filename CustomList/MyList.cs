using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T> : IEnumerable<T> 
    {
        T[] data;
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

        public void Add(T value)
        {
            if (count >= capacity/2)
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


        //public bool Remove(T value)
        //{
        //    List[count] = value;
        //    count--;
        //}
    }
}
