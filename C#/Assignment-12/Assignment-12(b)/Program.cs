using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_12_b_
{
    public class VehicleCollections
    {
        static void Main(string[] args)
        {
            AddVehicle Av = new AddVehicle();
            foreach (Vehicles item in Av)
            {
                Console.WriteLine(" Rating: "+item.Rating+ " CarName: "+ item.CarName+" Color: "+item.Color+" NamePlate: "+item.NamePlate);
                Console.WriteLine();
            }
            Console.ReadLine();
          

            
        }

     }
}
