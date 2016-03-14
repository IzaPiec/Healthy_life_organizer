using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOnYourOwn7
{
    class Program
    {
        static void Main(string[] args)
        {
            IrationalNumber number1 = new IrationalNumber();
            IrationalNumber number2 = new IrationalNumber();
            IrationalNumber number3 = new IrationalNumber();
            IrationalNumber number4 = new IrationalNumber();

            number1.getReal=4;
            number1.getUnreal=7;
            number2.getReal= 6;
            number2.getUnreal=14;
            
           

            Console.WriteLine("Numbers 1 real: {0} and unreal: {1}", number1.getReal, number1.getUnreal);
            Console.WriteLine("Numbers 2 real: {0} and unreal: {1}", number2.getReal, number2.getUnreal);
            number3 = number1 + number2;
            Console.WriteLine("Results of + operation : real {0} and unreal {1}", number3.getReal,number3.getUnreal);
            number4 = number1 * number2;
            Console.WriteLine("Results of * operation: real {0} and unreal {1}", number4.getReal, number4.getUnreal);

            Console.ReadLine();

        }
    }

    class IrationalNumber
    {
        private int real;
        private int unreal;

        public IrationalNumber()
        {
        }


        public int getReal
        {
            get {
                return real;
            }
            set {
                real = value;
            }
            
        }

        public int getUnreal
        {
            get {
                return unreal;
            }
            set {
                unreal = value;
            }
        }




        public static IrationalNumber operator +(IrationalNumber a, IrationalNumber b)
        {
            IrationalNumber number = new IrationalNumber();

            number.real = a.real + b.real;
            number.unreal = a.unreal + b.unreal;
            return number;
        }

        public static IrationalNumber operator *(IrationalNumber c, IrationalNumber d)
        {
            IrationalNumber n = new IrationalNumber();

            n.real = c.real * d.real;
            n.unreal = c.unreal * d.unreal;
            return n;
        }
    }
}
