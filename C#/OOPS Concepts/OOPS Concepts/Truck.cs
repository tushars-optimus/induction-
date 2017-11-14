using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    class Truck : Vehicles
    {
        public override void Details()
        {
            Console.WriteLine("Truck is heavy vehicle");
            Console.WriteLine("Tyres : " + "6 ");
        }
        public void Safety()
        {
            Console.WriteLine("Precaution : Seat belt is required");
        }

    }
}
