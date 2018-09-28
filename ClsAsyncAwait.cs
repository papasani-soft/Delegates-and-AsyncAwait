using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace async_await
{
    class ClsAsyncAwait
    {
       public static void CreateThread()
        {
            Method();
            Console.WriteLine("Main thread");
        }
        public async static void Method()
        {
            await Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread");//wait until the long task finfishes
        }
        public static void LongTask()
        {
            Thread.Sleep(20000);
        }
            
    }
}
