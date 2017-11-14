using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_12_a_
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicles v1 = new Vehicles { Rating = 4f, CarName = "Maruti swift", Color = "Red", NamePlate = "DL 5g 4567" };
            Vehicles v2 = new Vehicles { Rating = 4.5f, CarName = "Crata", Color = "Black", NamePlate = "UP 9N 3567" };
            Vehicles v3 = new Vehicles { Rating = 3.9f, CarName = "Waganar", Color = "White", NamePlate = "MP 5G 4567" };
            Vehicles v4 = new Vehicles { Rating = 4.2f, CarName = "Honda city", Color = "Red", NamePlate = "DL 8M 4757" };
            Vehicles v5 = new Vehicles { Rating = 4.3f, CarName = "I10", Color = "Black", NamePlate = "DL 9g 4637" };
            Vehicles v6 = new Vehicles { Rating = 4f, CarName = "Maruti swift", Color = "Red", NamePlate = "DL 5g 4567" };
            Vehicles v7 = new Vehicles { Rating = 4.3f, CarName = "Crata", Color = "Maroon", NamePlate = "UP 9N 3547" };

            List<Vehicles> list = new List<Vehicles>() { v1, v2, v3, v4,v5,v6,v7 };
            list.Sort();
            foreach (var vehicles in list)
            {
                
                
                Console.WriteLine(vehicles);
                Console.WriteLine();
            }

        
            Console.WriteLine("To check wheather Maruti Swift cars are equal");
            Console.WriteLine(v1.Equals(v6));
            Console.WriteLine();
            Console.WriteLine("To check wheather Crata cars are equal");
            Console.WriteLine(v2.Equals(v7));
            Console.ReadLine();
            Console.WriteLine("Iterating through Enumeration");

        }
    }
}
