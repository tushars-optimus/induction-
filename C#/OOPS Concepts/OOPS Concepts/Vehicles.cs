using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    class Vehicles
    {
        public string make;
        public int YearOFManufacturing;
        public string Mode;
        public float speed;
        public Vehicles()
        {
            make = null;
            YearOFManufacturing = 0;
            Mode = null;
            speed = 0;
        }
        public void Accelerate(int speed1)
        {
            speed += speed1;
        }
        public void Deaccelarate(int speed1)
        {
            speed -= speed1;
        }
        public void stop()
        {
            speed = 0;
        }
        public Boolean isMoving()
        {
            if (speed <= 0)
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
