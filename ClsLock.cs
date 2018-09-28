using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace async_await
{
    class ClsLock
    {
       static Maths objMaths = new Maths();
        public static void CreateThread2()
        {
            Thread t1 = new Thread(objMaths.Divide);
            t1.Start();
            objMaths.Divide();
        }
    }
    class Maths
    {
        public int Num1;
        public int Num2;

        Random o = new Random();
        public void Divide()
        {
            for (int i = 0; i < 10000; i++)
            {
                Num1 = o.Next(1,2);
                Num2 = o.Next(1,2);
                int result = Num1 / Num2;
                Num1 = 0;
                Num2 = 0;
            }
        }
    }
}
