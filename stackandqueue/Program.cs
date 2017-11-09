using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackandqueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //var stack = ImmutableStack<int>.Empty;
            //stack = stack.Push(13);
            //stack = stack.Push(7);

            ////display 7 follow by 13
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //int lastitem;
            //stack = stack.Pop(out lastitem);
            //stack = stack.Pop(out lastitem);
            //Console.WriteLine(lastitem);

            var stack = ImmutableStack<int>.Empty;
            stack = stack.Push(13);
            var bigstack = stack.Push(7);

            //display 7 follow by 13
            foreach (var item in bigstack)
            {
                Console.WriteLine(item);
            }

            //only display 13
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
