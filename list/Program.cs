using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = ImmutableList<int>.Empty;
            list = list.Insert(0, 13);
            list = list.Insert(0, 7);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list = list.RemoveAt(1);
            Console.ReadKey();
        }
    }
}
