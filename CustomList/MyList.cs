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
            capacity = 20;
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
          
            for (int i = 0; i < Count; i++)
            {
                if (Compare(data[i], (value)) == false)
                {
                    AddToNewArray(data, newData);
                }
                else
                {
                    count--;
                    continue;
                }
            }
            data = newData;
        }

        private void AddToNewArray(T[] data, T[] newData)
        {
         for (int j = 0; j < count; j++)
          {
             newData[j] = data[j];
          }
        }
        public override string ToString()
        {
            foreach (T value in data)
            {
                value.ToString();
            }
            string concatenatedList = string.Join(" ", data);
            return concatenatedList;
        }

        public static MyList<T> operator +(MyList<T> list1, MyList<T> list2)
        {
            MyList<T> AddedList = new MyList<T>();

            AddedList.count = list1.count + list2.count;
            
            for (int i = 0; i < list1.count; i++)
            {
                AddedList[i] = list1[i];

                for (int j = 0 + i; j < list2.count; j++)
                {
                   AddedList[i + list1.count] = list2[j];
                    j++;
                   break;
                }
            }
            return AddedList;
        }
        //COMPLETELY WRONG
        public static MyList<T> operator -(MyList<T> list1, MyList<T> list2)
        {
            MyList<T> SubtractedList = new MyList<T>();

            SubtractedList.count = list1.count - list2.count;

            for (int i = list1.count; i > 0; i--)
            {
                for (int j = list2.count; i > 0; j++)
                {
                    if (list1[i].Equals(list2[j]))
                    {
                        continue;
                    }
                    else
                    {
                        SubtractedList.Add(list1[i]);
                    }
                }
                            
            }
            return SubtractedList;
        }

        public MyList<T> Zip(MyList<T> list1, MyList<T> list2)

       {
            MyList<T> zipList = new MyList<T>();
           
            for (int i = 0; i < list1.count; i++)         
            {
                zipList.Add(list1[i]);
                zipList.Add(list2[i]);
            }
            return zipList;
        }
    }
}
