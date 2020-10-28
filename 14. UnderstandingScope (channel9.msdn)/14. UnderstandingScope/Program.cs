using System;
using System.Globalization;

namespace _14._UnderstandingScope
{
    class Program
    {
        private static string k = "";
        static void Main(string[] args)
        {
            string j = "";
            for(int i=0;i<10;i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine("The value of l: {0}",l);
            }
            //Console.WriteLine(i);
            Console.WriteLine("Value of j ourside the for loop: {0}", j);
            Console.WriteLine("Value of k ourside the for loop: {0}", k);
            HelperMethod();

            Car myCar = new Car();
            myCar.DoSomething();

            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of k inside the HeperMethod: {0}",k);
        }
    }
    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }
        private string helperMethod()
        {
            return "Hello World!";
        }
    }
}
