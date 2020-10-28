using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";

            Book b1 = new Book();
            b1.Author = "Manuel Osorio";
            b1.Title = "Introduction to programming languages";
            b1.ISBN = "0-000-00000-0";

            /*
            //ArrayLists dynamicaly assigned
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            //myArrayList.Add(b1);

            foreach(Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */

            /*
            // List<T>
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1);
            foreach(Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            */

            /*
            //Dictionary <TKey,TValue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.Model, car1);
            myDictionary.Add(car2.Model, car2);

            Console.WriteLine(myDictionary["Prism"].Make);
            */

            //string name[] = { "Bob", "Steve", "Brian", "Chuck" };
            Car car3 = new Car() { Make = "BMW", Model = "750li" };
            Car car4 = new Car() { Make = "Toyota", Model = "4Runner" };

            List<Car> myList = new List<Car>() {
                new Car {Make = "BMW", Model = "750li"},
                new Car() { Make = "Toyota", Model = "4Runner" }
            };

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }


}
