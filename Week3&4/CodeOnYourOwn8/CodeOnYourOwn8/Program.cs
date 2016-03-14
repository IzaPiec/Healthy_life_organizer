using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOnYourOwn8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Circle myCircle = new Circle(3);
            Cylinder myCylinder = new Cylinder(4);
            
            
            Console.WriteLine("Circle area: {0}",
                myCircle.Area());

            Console.WriteLine("Cylinder volume: {0}",
                 myCylinder.Volume());


            Console.ReadLine();

        }
    }

    class Circle
    {
        private double Radius;

        public Circle()
        {
            this.Radius = 1;
        }

        public Circle( double Radius)
        {
            this.Radius = Radius;
        }

        //public double getRadius
        //{
        //    get 
        //    {
        //        return radius;    
        //    }
        //    set
        //    {
        //        radius = value;
        //    }
            
        //}

        public double Area()
        {
            double radius = Radius;
            double pi = 3.14;
            double d = Radius * Radius;
            double area = pi * d;
            return area;
        }

    }

    class Cylinder : Circle
    {
        private double Height;
        public Cylinder()
            :base()
        {
            this.Height = 1;
        }

        public Cylinder(double Height)
            :base(Height)
        {
            this.Height = Height;
        }

        public double Volume()
        {
            double a = base.Area();
            double height = Height;
            double volume = a * height;
            return volume;

        }
    }

}
