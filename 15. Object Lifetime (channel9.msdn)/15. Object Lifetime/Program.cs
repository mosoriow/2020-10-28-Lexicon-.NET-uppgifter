using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Object_Lifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car.MyMethod();
            Car myCar = new Car();

            Console.WriteLine("constructor: {0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);

            myCar.Make = "Oldmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            myOtherCar.Model = "98";
            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);

            myOtherCar = null;
            //Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);
            myCar = null;

            Car myThridCar = new Car("Ford", "Escape", 2005, "White");
            Console.WriteLine("{0} {1} {2} {3}", myThridCar.Make, myThridCar.Model, myThridCar.Year, myThridCar.Color);

            Console.ReadKey();
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
            //this.Make = "Nissan";
            Make = "Nissan";
        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
            //Console.WriteLine(Make);
        }
    }

}
