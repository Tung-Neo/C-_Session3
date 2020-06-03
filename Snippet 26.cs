using System;
using System.Collections.Generic;
using System.Text;

namespace Tung_Neo.Session_3
{
    class Snippet_26
    {
        static void code26()
        {
            float radius = 4.5F;
            double circumference;
            circumference = 3.14 * 2 * radius;
            object boxed = (object) circumference;
            Console.WriteLine("Circumference of the circle = {0}", boxed);
        }
    }
}
