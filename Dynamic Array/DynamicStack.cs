using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Array
{
    public class DynamicStack <T>
    {
        DynamicArray<T> Stack = null;
       

        public DynamicStack () 
        {
            Stack = new DynamicArray<T>();
        }

        public void Push(T value)
        {
            Stack.Add(value);   
        }

        public T Pop()
        {
            if (isEmpty())
            {
                return default(T);
            }
            else
            {
                T i = Stack.Get(Stack.Size-1);
                Stack.Remove(Stack.Size-1);
                return i;
            }
        }

        public bool isEmpty()
        {
            if (Stack.Size == 0)
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
            if (Stack.Size <= 0)
            {
                Console.WriteLine("Array is empty");
            }
            else
            {
                for (int i = 0; i < Stack.Size; i++)
                {
                    Console.WriteLine(Stack.Get(i));
                }
            }
        }
    }
}
