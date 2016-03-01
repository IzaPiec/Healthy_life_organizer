using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatementsCSF08
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, a, b;

            //Assignemt operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            //There are many mathematical operators...

            //Addition operator
            x = 3 + 4;

            //Subtraction operat
            x = 4 - 3;

            //Multiplication operator
            x = 10 * 5;

            //Division operator
            x = 10 / 5;

            //There are many operatirs used to evauate values...

            //Equality operator

            if (x==y)
            {
            }

            //Greater than operator
            if (x > y)
            {
            }

            //Less than operator
            if (x < y)
            {
            }

            //Greater than or equal operator
            if (x >= y)
            {
            }

            //Less than or equal operator
            if (x <= y)
            {
            }

            //There are two "conditinal" operators as well that can be used to expand / enhance an evaluation
            //...and they can be ompbined together multiple times.

            //Consitional AND operator
            if ((x > y) && (a > b))
            {
            }

            //Consitional OR operator
            if ((x > y) || (a > b))
            {
            }

            //ALso, here's he in-line conditional oprator we learned about in the previous lesson
            string message = (x == 1) ? "Car" : "Boat";

            //Member access and Method invocation
            Console.WriteLine("Hi");


        }
    }
}
