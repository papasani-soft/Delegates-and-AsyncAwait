using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter program no.to execute");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    ClsDelegates obj1 = new ClsDelegates();
                    //obj1.Add(25,30);
                    //ClsDelegates.SayHello("anji");
                    AddDelegate ad = new AddDelegate(obj1.Add);
                    ad.Invoke(10, 20);
                    SayDelegate sd = new SayDelegate(ClsDelegates.SayHello);
                    sd.Invoke("anji");
                    break;
                case 2:
                    ClsMultiCastDelegates obj2 = new ClsMultiCastDelegates();
                    RectDelegate rd = obj2.GetArea;
                    rd+=obj2.GetParameter;
                    rd.Invoke(30.5,20.5);
                    break;
                case 3:
                   // ClsAnonymous obj3 = new ClsAnonymous();
                    //DelGreetings dg = new DelGreetings(obj3.Greetings);
                    //dg(" anji");
                    DelGreetings dg = delegate (string name)
                      {
                          Console.WriteLine("Hello" + name + " a very good morning");
                      };
                    dg(" anji");
                    break;
                case 4:
                    //DelGreetings dg1 = delegate (string name)
                    //{
                    //    Console.WriteLine("Hello" + name + " a very good morning");
                    //};
                    DelGreetings dg1 =(name)=>
                    {
                        Console.WriteLine("Hello" + name + " a very good morning");
                    };
                    dg1(" anji");
                    break;
                case 5:
                    ClsGenericDelegate.CreateDelegate();
                    break;

                default:
                    break;
            }
            Console.Read();
        }
    }
} 