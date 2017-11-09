using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsyncInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static async Task UseMyInterfaceAsync(IMyAsyncInterface service)
        {
            var result = await service.CountByteAsync("http://www.example.com");
            Console.WriteLine(result);
        }
    }
    interface IMyAsyncInterface
    {
        Task<int> CountByteAsync(string url);
    }

    class MyAsyncClass : IMyAsyncInterface
    {
        public async Task<int> CountByteAsync(string url)
        {
            var client = new HttpClient();
            var bytes = await client.GetByteArrayAsync(url);
            return bytes.Length;
        }
    }

    
}
