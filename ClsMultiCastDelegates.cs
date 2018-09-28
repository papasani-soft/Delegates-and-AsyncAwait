using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate void RectDelegate(double width, double height);
    class ClsMultiCastDelegates
    {
        public void GetArea(double width,double height)
        {
            Console.WriteLine("Area of rectangle is"+width*height);
        }
        public void GetParameter(double width, double height)
        {
            Console.WriteLine("parameter of the rectangle is"+2*(width+height));
        }
    }
}
