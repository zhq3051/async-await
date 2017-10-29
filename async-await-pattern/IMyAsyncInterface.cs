using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace async_await_pattern
{
    interface IMyAsyncInterface
    {
        Task<int> GetValueAsync();
    }

    class MySynchronousImplementation: IMyAsyncInterface
    {
        public Task<int> GetValueAsync()
        {
            return Task.FromResult(13);
        }
    }
}
