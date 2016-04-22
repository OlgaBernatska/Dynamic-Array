using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Array
{
    public class DynamicQueue<T>
    {
        DynamicArray<T> Queue = null;

        public DynamicQueue()
        {
            Queue = new DynamicArray<T>();
        }

        public void Enqueue(T value)
        {
            Queue.Add(value);
        }

        public T Dequeue()
        {
            if (isEmpty())
            {
                return default (T);
            }
            else
            {
                T i = Queue.Get(0);
                Queue.Remove(0);
                return i;
            }
        }

        public bool isEmpty()
        {
            if (Queue.Size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            if (Queue.Size <= 0)
            {
                Console.WriteLine("Array is empty");
            }
            else
            {
                for (int i = 0; i < Queue.Size; i++)
                {
                    Console.WriteLine(Queue.Get(i));
                }
            }
        }
    }
}
