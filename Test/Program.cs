using System;
using System.Collections;
using System.Collections.Generic;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MyClass myClass = new MyClass();
            MyClass<int> myClass = new MyClass<int>();

            myClass.Price=20;

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);


            var valu = queue.Dequeue();//siradaki her birinci obyekt deyerini cixardir.
            var value = queue.Peek(); //siradaki birinci novbeli deyeri gosterir.

            Console.WriteLine(queue.Peek());
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }


            Stack stack = new Stack();

            stack.Push(5);
            stack.Push("A");
            stack.Push("20");

            var newValue = stack.Pop(); // siyahida en axnrcini deyeri birinci edir sonra onu siyahidan cixardir
            stack.Peek();

        }
    }
    class MyClass<T>
    {
        public string Name;

        public T Price;

    }
}
