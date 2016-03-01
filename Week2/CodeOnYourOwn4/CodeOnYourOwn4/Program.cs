using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeOnYourOwn4
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFromFile;
            using (var streamReader = new StreamReader(@"C:\Users\Iza\Documents\Visual Studio 2015\Projects\CodeOnYourOwn4\CodeOnYourOwn4\ReadingAFile.txt", Encoding.UTF8))
            {
                textFromFile = streamReader.ReadToEnd();
                Console.WriteLine(textFromFile);
            }


            Console.ReadLine();
        }
    }
}
