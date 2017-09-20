using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    class Bike : Vehicles
    {
        public override void Details()
        {
            Console.WriteLine("Bike is light vehicle");
            Console.WriteLine("Tyres : " + "2 ");
        }
        public void Safety()
        {
            Console.WriteLine("Precaution : Helmet is required");
        }

    }
}
