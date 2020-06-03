using System;
using System.Collections.Generic;
using System.Text;

namespace Tung_Neo.Session_3
{
    class Snippet_19
    {
        static void code19()
        {
            uint num = 100;
            uint result = num << 1;
            Console.WriteLine("Value before left shift: " + num);
            Console.WriteLine("Value after left shift: " + result);
            num = 80;
            result = num >> 1;
            Console.WriteLine("\nValue before right shift: " + num);
            Console.WriteLine("Value after right shift: " + result);
        }
    }
}
