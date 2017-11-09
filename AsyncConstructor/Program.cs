using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class MyAsyncClass
    {
        private MyAsyncClass()
        {
        }

        private async Task<MyAsyncClass> InitializeAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            return this;
        }

        public static Task<MyAsyncClass> CreateAsync()
        {
            var result = new MyAsyncClass();
            return result.InitializeAsync();
        }
    }
}
