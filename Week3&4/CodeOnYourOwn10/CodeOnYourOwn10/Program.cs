using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOnYourOwn10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 16;
            int y = 96;

            Swap(ref x, ref y);
            Console.WriteLine("Passed by reference x: {0} and y: {1}",
                x,
                y);

            Console.ReadLine();

        }

        public static void Swap(ref int x, ref int y)
        {
            int a =x;
            x=y;
            y=a;

        }
    }
}
