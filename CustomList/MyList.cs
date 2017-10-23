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
        T[] List = new T[5];
        T value;
        int count;
        int capacity;
        
        public MyList()
        {
           
        }
        
        public MyList(T value)
        {
            this.value = value;
        }


        public int Count
        {
            get { return count; }
        }

        public int Capacity
        {
            get { return capacity; }

            set { capacity = value; }
        }

        public T this[int index]
        {
            get
            {
                return List[index];
            }

            set
            {
                List[index] = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)List).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)List).GetEnumerator();
        }

        public void Add(T value)
        {
            List[count] = value;
                count++; 
        }

        //public void Remove(T value)
        //{
        //    List[count] = value;
        //    count--;
        //}
    }
}
