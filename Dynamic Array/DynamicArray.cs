using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Array
{
    public class DynamicArray<T>
    {
        private int size = 0;
        private T[] array;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public DynamicArray()
        {
            array = new T[1];
        }

        public int Capacity
        {
            get { return array.Length; }
        }

        public void ResizeArray()
        {
            T[] resizedArray = new T[Capacity * 2];
            for (int i = 0; i < Size; i++)
            {
                resizedArray[i] = array[i];
            }
            array = resizedArray;
        }

        public void Add(T value)
        {
            if (Size >= Capacity)
            {
                ResizeArray();
            }
            array[Size] = value;
            Size++;
        }

        public void Insert(int index, T value)
        {
            if (!(index >= 0 && index < size))
            {
                return;
            }
            else
            {
                if (Size >= Capacity)
                {
                    ResizeArray();
                }

                Size++;
                T shiftValue = value;

                for (int i = 0; i < size; i++)
                {
                    if (i >= index)
                    {
                        T temp = array[i];
                        array[i] = value;
                        shiftValue = temp;
                    }
                }
            }
        }

        public void Remove(int index)
        {
            if (!(index >= 0 && index < size))
            {
                return;
            }
            else
            {
                size--;
                for (int i = 0; i < size; i++)
                {
                    if (i >= index)
                    {
                        array[i] = array[i + 1];
                    }

                }
                array[size] = default(T);
            }
        }

        public T Get(int index)
        {
            if (index <= Size && index >= 0)
            {
                return array[index];
            }
            else
            {
                return default(T);
            }
        }

        public void Print()
        {
            if (Size <= 0)
            {
                Console.WriteLine("Array is empty");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
