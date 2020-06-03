using System;
using System.Collections.Generic;
using System.Text;

namespace Tung_Neo.Session_3
{
    class Snippet_20
    {
        static void code20()
        {
            int num = 6;
            string msg = "";
            if(num < 0)
            {
                msg = "The number " + num + " is negative";
            }
            else if((num % 2) == 0)
            {
                msg = "The number " + num + " is even";
            }
            else
            {
                msg = "The number " + num + " is odd";
            }
            if (msg != "")
                Console.WriteLine(msg);
        }
    }
}
