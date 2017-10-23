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
        T[] List = { };
        T value;
        int count;
        
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

        }

        public void Remove(T value)
        {

        }
    }
}
