using System;
using System.Collections.Generic;
using System.Text;

namespace Tung_Neo.Session_3
{
    class Snippet_27
    {
        static void code27()
        {
            int length = 10;
            int breadth = 20;
            int area;
            area = length * breadth;
            object boxed = area;
            int num = (int)boxed;
            Console.WriteLine("Area of the rectangle = {0}", num);
        }
    }
}
