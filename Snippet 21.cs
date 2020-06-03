using System;
using System.Collections.Generic;
using System.Text;

namespace Tung_Neo.Session_3
{
    class Snippet_21
    {
        public static void code21()
        {
            int numOne = 5, numTwo = 25, numThree = 15, result = 0;
            if(numOne > numTwo)
            {
                result = (numOne > numThree) ? result = numOne : result = numThree;
            }
            else
            {
                result = (numTwo > numThree) ? result = numTwo : result = numThree;
            }
            if (result != 0)
                Console.WriteLine("{0} is the largest number", result);
        }
    }
}
