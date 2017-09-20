using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    class Bicycle : Vehicles
    {
        public override void Details()
        {
            Console.WriteLine("Bicycle is light vehicle");
            Console.WriteLine("Tyres : " + "2 ");
        }
        public void Safety()
        {
            Console.WriteLine("Precaution : No requirement");
        }

    }
}
