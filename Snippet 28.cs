using System;
using System.Collections.Generic;
using System.Text;

namespace Tung_Neo.Session_3
{
    class Snippet_28
    {
        static void Main(String[] args)
        {
            int num = 8;
            int result;
            result = Square(num);
            Console.WriteLine("Square of {0} = {1}", num, result);
        }
        static int Square(object inum)
        {
            return (int)inum * (int)inum;
        }
    }
}
