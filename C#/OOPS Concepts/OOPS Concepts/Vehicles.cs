using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    class Vehicles
    {
        public string Make;
        public int YearOFManufacturing;
        public string Mode;
        public float Speed;
        public Vehicles()
        {
            Make = null;
            YearOFManufacturing = 0;
            Mode = null;
            Speed = 0;
        }
        public void Accelerate(int speed1)
        {
            Speed += Speed;
        }
        public void Deaccelarate(int speed1)
        {
            Speed -= Speed;
        }
        public void Stop()
        {
            Speed = 0;
        }
        public Boolean isMoving()
        {
            if (Speed <= 0)
            {
                return false;
            }
            return true;
        }
        //Wheels is overriding in base class
        public virtual void Details()
        {
            Console.WriteLine("Tyres : " + "0");
        }
    }
}
