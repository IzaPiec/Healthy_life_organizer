using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOnYourOwn3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random getRandom = new Random();
            Console.WriteLine("Random numbers:\n");
            for (int i = 0; i < array.Length; i++)
            {
                
                array[i] = getRandom.Next(21);
                Console.WriteLine("{0}", array[i]);
            }
         
                
            Array.Sort(array);
            Console.WriteLine("\nSorted numbers:\n");
            foreach (var j in array)
                Console.WriteLine("{0}", j);

            Console.ReadLine();
        }
    }
}
