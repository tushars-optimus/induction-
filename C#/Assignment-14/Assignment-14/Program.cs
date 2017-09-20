using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14
{
    class Program
    {
        public static int Count = 1;
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle("Bike", "Black",2);
            Vehicle vehicle2 = new Vehicle("Car", "Green",4);
            Vehicle vehicle3 = new Vehicle("Truck", "Yellow",6);
            Vehicle vehicle4 = new Vehicle("Scooter", "Pink",2);
            Vehicle vehicle5 = new Vehicle("Scooter", "Pink", 2);
            Vehicle vehicle6 = new Vehicle("Bicyle", "red", 2);
            List<Vehicle> collection = new List<Vehicle>();
            collection.Add(vehicle1);
            collection.Add(vehicle2);
            collection.Add(vehicle3);
            collection.Add(vehicle4);
            collection.Add(vehicle5);
            collection.Add(vehicle6);
            Console.WriteLine("Unsorted Vehicle");
            Console.WriteLine();
            foreach (var item in collection)
            {
                Console.WriteLine(Count + ")" + item);
                Count++;
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Sorted Vehicle");
            Console.WriteLine();
            collection.Sort();
            foreach (var item in collection)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
            Console.WriteLine("checking for Equality between vehicle 1 and vehicle 2");
            Console.WriteLine(vehicle1.Equals(vehicle2));
            Console.WriteLine("checking for Equality between vehicle 1 and vehicle 5");
            Console.WriteLine(vehicle1.Equals(vehicle5));
            Console.WriteLine("checking for Equality between vehicle 4 and vehicle 5");
            Console.WriteLine(vehicle5.Equals(vehicle4));
            Console.ReadLine();
        }
    }
}
