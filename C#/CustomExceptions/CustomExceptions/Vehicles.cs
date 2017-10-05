using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public class Vehicles
    {
        const int CarMax = 220;
        const int BicycleMax = 100;
        const int CarExplode = 280;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
    
    private int _speed;

	public int Speed
	{
		get { return _speed;}
		set { _speed = value;}
	}
        public int Accelerate(int speed)
    {
        Speed = Speed + speed;
        return Speed;
    }
        public int Deaccelerate(int speed)
        {
            Speed = Speed - speed;
            return Speed;
        }

        public void check()
        {
            try
            {
                if (Name == "Car")
                {
                    Console.WriteLine(" Car speed is " + Speed);
                }
                if (Name == "Bicycle")
                {
                    Console.WriteLine(" Bicycle speed is " + Speed);
                }
                if (Speed > CarMax && Name == "Car" && Speed < CarExplode)
                {
                    throw new IsCarDeadException("Car has overheated");
                }
                if (Speed > BicycleMax && Name == "Bicycle")
                {
                    throw new IsCarDeadException("Bicycle can not go above 100 km/hr");
                }
                if (Speed > CarExplode && Name == "Car")
                {
                    
                    throw new IsCarDeadException("Car exploded");
                }
            }
            catch (IsCarDeadException e)
            {
                string Time = DateTime.Now.ToShortTimeString();
                Console.WriteLine("Exception thrown: " + " Speed: " + Speed +" "+e.Message + " Time is " + Time);
            }
            
            
        }
  }
}
