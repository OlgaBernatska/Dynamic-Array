using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Array
{
    class Program 
    {
        static void Main(string[] args)
        {
            //DynamicArray<int> myDA = new DynamicArray<int>();
            //myDA.Add(0);
            //myDA.Add(1);
            //myDA.Add(2);
            //myDA.Add(3);
            //myDA.Print();
            //Console.WriteLine("-----------------");

            ////myDA.Remove(2);

            //myDA.Print();
            //Console.WriteLine("-----------------");
            //Console.ReadKey();

            //DynamicStack<int> stack = new DynamicStack<int>();
            //stack.Push(0);
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Print();
            //Console.WriteLine("--------------------");
            //stack.Pop();
            //stack.Pop();
            //stack.Print();
            //Console.ReadKey();


            DynamicQueue<int> queue = new DynamicQueue<int>();
            queue.Enqueue(0);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Print();
            
            Console.WriteLine("------------------------");
            queue.Dequeue();
            queue.Dequeue();
            queue.Print();
            Console.ReadKey();


        }
    }
}
