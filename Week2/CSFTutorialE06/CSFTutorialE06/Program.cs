using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFTutorialE06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            */

            //string myFirstName;
            //myFirstName = "Iza";
            //string mysfirstname;

            //string myFirstName = "Iza";
            //var myFirstName = "Iza";
            //Console.WriteLine(myFirstName);

            int x = 7;
            //string y = "Iza";
            string y = "5";
            string myFirstTry = x.ToString() + y;

            //int mySecondTry = x + y;
            int mySecondTry = x + int.Parse(y);


            Console.WriteLine(myFirstTry);
           // Console.WriteLine(mySecondTry);

            Console.ReadLine();
        }
    }
}
