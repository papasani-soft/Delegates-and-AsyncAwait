using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace async_await
{
    class ClsThread
    {
        public static void CreateThread1()
        {
           Thread obj1=new Thread( Function1);
           Thread obj2=new Thread( Function2);
            obj1.Start();
            obj2.Start();
        }
        static void Function1()
        {
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Function 1 executed" +i.ToString());
                Thread.Sleep(4000);
            }
        }
        static void Function2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Function 2 executed" + i.ToString());
                Thread.Sleep(4000); 
            }
        }
    }
}
