using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOnYourOwn9
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            
            myArrayList.Add(3.0);
            myArrayList.Add(null);
            myArrayList.Add(5.6);
            myArrayList.Add(6.1);
            myArrayList.Add(null);

            Console.WriteLine("Content of the myArrayList:");
            foreach (double? i in myArrayList)
            {
                Console.WriteLine(i + " ");
            }
            Console.ReadLine();


        }
    }

    class Utils
    {

        public static double Count(List<double?> a)
        {
            

            return a;
        }

        public static double Minimum()
        {
          
        }
        public static double Maximum()
        {

        }

        public static double Avarage()
        {

        }

        public static double Sum()
        {

        }
    }


}
