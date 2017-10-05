using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Vehicles vehicle1 = new Vehicles() { Name = "Car", Speed = 80 };
            Vehicles vehicle2 = new Vehicles() { Name = "Bicycle", Speed = 40 };
            for (int i = 30; i < 150;i=i+30)
            {
                vehicle1.Accelerate(i);
                vehicle1.Deaccelerate(10);
                vehicle1.check();
                vehicle2.Accelerate(i);
                vehicle2.Deaccelerate(20);
                vehicle2.check();
            }
                Console.ReadLine();

        }
    }
}
