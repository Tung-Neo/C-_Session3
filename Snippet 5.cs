using System;
using System.Collections.Generic;
using System.Text;

namespace Tung_Neo.Session_3
{
    class Snippet_5
    {
        public static void code5()
        {
            byte numOne = 255;
            byte numTwo = 1;
            byte resutl = 0;
            try
            {
                unchecked
                {
                    resutl = (byte)(numOne + numTwo);
                }
                Console.WriteLine("Result: " + resutl);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
