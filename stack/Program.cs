using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main()
        {
            var a = new Stack();
            
            for (int x = 0; x < 5; x++)
            {
                a.Push(new Node { Inf = x, Next = null });
            }

            //a.Pop(new Node { });

            List<Node> mstack = a.Peek();
           
            foreach (Node i in mstack)
            {
                Console.WriteLine(i.Inf);
            }

            Console.WriteLine("\n" + "count = " + a.Count);

            a[1].Inf = 5;
            Console.WriteLine(a[1].Inf);
            Console.WriteLine(a[2].Inf);
            Console.ReadLine();
        }
    }
}
