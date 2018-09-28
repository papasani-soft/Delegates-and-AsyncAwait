using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate double Delegate1(int x, float y, double z);
    public delegate double Delegate2(int x, float y, double z);
    public delegate bool Delegate3(string str);
    class ClsGenericDelegate
    {
        //public static double AddNums1(int x, float y, double z)
        //{
        //    return x + y + z;
        //}
        //public static void AddNums2(int x, float y, double z)
        //{
        //     Console.WriteLine(x+y+z);
        //}
        //public static bool CheckLength(string str)
        //{
        //    if (str.Length > 5)
        //        return true;
        //    return false;
        //}
        public static  void CreateDelegate()
        {
           
            //Delegate1 d1 = AddNums1;
            //double result = d1.Invoke(10, 20.2f, 53.454);
            //Console.WriteLine(result);

            ////Delegate2 d2 = AddNums2;
            ////d2.Invoke(10, 20.2f, 53.454);

            //Delegate3 d3 = CheckLength;
            //bool status = d3.Invoke("hello");
            //Console.WriteLine(status);

            Func< int,float,double,double >d1 =  (x,y,z)=>
            {
                return x + y + z;
            };
            double result = d1.Invoke(10, 20.2f, 53.454);
            Console.WriteLine(result);

            Action<int ,float,double> d2 = (x,y,z)=>
            {
                Console.WriteLine(x + y + z);
            };
            d2.Invoke(10, 20.2f, 53.454);

            Predicate<string> d3 = (str)=>
            {
                if (str.Length > 5)
                    return true;
                return false;
            };
            bool status = d3.Invoke("hello");
            Console.WriteLine(status);
        }
    }
}
