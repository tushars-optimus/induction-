using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    class Car : Vehicles
    {
        public override void Details()
        {
            Console.WriteLine("Car is light vehicle");
            Console.WriteLine("Tyres : " + "4 ");
        }
        public void Safety()
        {
            Console.WriteLine("Precaution : Seat belt is required");
        }

    }
}
