using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOnYourOwn2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "!!!I am learning !!!";
            string secondString = "--C#--";
            string thirdString = firstString.Trim(new Char[] {'!'})+secondString.Trim(new Char[] {'-'}) ;

            Console.WriteLine(thirdString);
            Console.ReadLine();


        }
    }
}
