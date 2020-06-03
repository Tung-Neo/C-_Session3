using System;
using System.Collections.Generic;
using System.Text;

namespace Tung_Neo.Session_3
{
    class Snippet_11
    {
        public static void code11()
        {
            int quantity = 1900;
            double price = 9.1;
            if ((quantity == 2000) ^ (price == 10.5))
            {
                Console.WriteLine("You have to compromise betwwen quantity and price");
            }
        }
    }
}
