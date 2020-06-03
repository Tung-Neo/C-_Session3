using System;
using System.Collections.Generic;
using System.Text;

namespace Tung_Neo.Session_3
{
    class Snippet25
    {
        static void code25()
        {
            int radius = 10;
            double area;
            area = 3.14 * radius * radius;
            object boxed = area;
            Console.WriteLine("Area of the circle = {0}", boxed);
        }
    }
}
