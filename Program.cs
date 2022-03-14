using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Troelsen
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 100;
            byte b = 250;

            unchecked
            {
                byte sum = (byte)Add(a, b);
                Console.WriteLine(sum);
            }

            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
