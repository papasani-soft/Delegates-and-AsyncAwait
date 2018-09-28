using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    //step 1: difining a delegate
    public delegate void AddDelegate(int x, int y);
    public delegate void SayDelegate(string str);
    class ClsDelegates
    {
        public void Add(int i, int j)
        {
            Console.WriteLine( i + j);
        }
        public static void SayHello(string name)
        {
            Console.WriteLine("hello"+name);
        }

    }
}
