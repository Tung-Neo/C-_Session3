using System;
using System.Collections.Generic;
using System.Text;

namespace Tung_Neo.Session_3
{
    class Snippet_9
    {
        public static void code9()
        {
            int quantity = 1900;
            double price = 9.1;
            if((quantity > 2000) | (price < 10.5))
            {
                Console.WriteLine("You can buy more goods at a lower price");
            }
        }
    }
}
