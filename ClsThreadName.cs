using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace async_await
{
    public class MyThread2
    {
        public void Thread1()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name + " is running");
        }
    }
    public class ThreadExample2
    {
        public static void CreateThread5()
        {
            MyThread2 mt = new MyThread2();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));
            t1.Name = "Player1";
            t2.Name = "Player2";
            t3.Name = "Player3";
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
