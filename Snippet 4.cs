using System;
using System.Collections.Generic;
using System.Text;

namespace Tung_Neo.Session_3
{
    class Snippet_4
    {
        public static void code4()
        {
            byte numOne = 255;
            byte numTwo = 1;
            byte result = 0;
            try
            {
                checked
                {
                    result = (byte)(numOne + numTwo);
                }
                Console.WriteLine("Result: " + result);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
