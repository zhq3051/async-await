using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptionFromAsyncMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAsync();
            Console.ReadKey();
        }

        static async Task ThrowExceptionAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            throw new InvalidOperationException("Test");
        }

        static async Task TestAsync()
        {
            Task task = ThrowExceptionAsync();
            try
            {

                //await ThrowExceptionAsync();
                await task;
            }
            catch (InvalidOperationException)
            {
                Console.Write("111");
            }
        }
    }
}
