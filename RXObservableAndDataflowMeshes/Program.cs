using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace RXObservableAndDataflowMeshes
{
    class Program
    {
        static void Main(string[] args)
        {
            //the code in the book is out of style. so just end up the coding.
            var buffer = new BufferBlock<int>();
            IObservable<int> integers = buffer.AsObservable();
            //integers.Subscribe(data => Console.WriteLine(data), ex => Console.WriteLine(ex), () => Console.WriteLine("done"));
        }
    }
}
