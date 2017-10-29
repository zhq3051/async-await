using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessTaskAsTheyComplete
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessTaskAsync();
            Console.ReadKey();
        }

        #region the sequece 2,3,1
        static async Task<int> DelayAndReturnAsync(int val)
        {
            await Task.Delay(TimeSpan.FromSeconds(val));
            return val;
        }


        //static async Task ProcessTaskAsync()
        //{
        //    Task<int> taskA = DelayAndReturnAsync(2);
        //    Task<int> taskB = DelayAndReturnAsync(3);
        //    Task<int> taskC = DelayAndReturnAsync(1);

        //    var tasks = new[] { taskA, taskB,taskC };

        //    foreach (var task in tasks)
        //    {
        //        var result = await task;
        //        Trace.WriteLine(result);
        //        Console.WriteLine(result);
        //    }
        //} 
        #endregion

        #region the squence 1,2,3
        static async Task AwaitAndProcessAsync(Task<int> task)
        {
            var result = await task;
            Console.WriteLine(result);
        }
        static async Task ProcessTaskAsync()
        {
            Task<int> taskA = DelayAndReturnAsync(2);
            Task<int> taskB = DelayAndReturnAsync(3);
            Task<int> taskC = DelayAndReturnAsync(1);

            var tasks = new[] { taskA, taskB, taskC };
            
            //var processingTasks = (from t in tasks select AwaitAndProcessAsync(t)).ToArray();
            var processingTasks = tasks.Select(async t => { var result = await t; Console.WriteLine(result); return result; }).ToArray();

            var k = await Task.WhenAll(processingTasks);
        } 
        #endregion
    }
}
