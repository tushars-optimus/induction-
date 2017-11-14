using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsNLists2
{
    class TestCollection
    {
        static void Main()
        {
            Vehicle vehicle1 = new Vehicle("Bike", "Black");
            Vehicle vehicle2 = new Vehicle("Car", "Green");
            Vehicle vehicle3 = new Vehicle("Truck", "Yellow");
            Vehicle vehicle4 = new Vehicle("Scooter", "Pink");
            ArrayList vehiclelist = new ArrayList();
             vehiclelist.Add(vehicle1);
             vehiclelist.Add(vehicle2);
             vehiclelist.Add(vehicle3);
             vehiclelist.Add(vehicle4);
            //Using Enumeration
             Console.WriteLine("Using Enumeration");
             Console.WriteLine();
             foreach (Vehicle item in vehiclelist)
             {
                 Console.WriteLine(item);
             }
            //Using index
             Console.WriteLine();
             Console.WriteLine("Using Index Value");
             for (int i = 0; i < vehiclelist.Count; i++)
             {
                 Console.WriteLine(vehiclelist[i]);
             }
             

             Console.ReadLine();
        }
        
    }
}
