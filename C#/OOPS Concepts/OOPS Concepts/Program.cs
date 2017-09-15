using OOPS_Concepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{   
    class Program
    {
        static void Main(string[] args)
        {
            Car Car=new Car();
            Truck Truck=new Truck();
            Bike Bike=new Bike();
            Bicycle Bicycle=new Bicycle();
            Car.Accelerate(50);
            Truck.Accelerate(40);
            Bicycle.Accelerate(30);
            Bicycle.Deaccelarate(10);
            
            Console.WriteLine(@"Which vehicle Statusu Would you like to see
1-Bicycle
2-Bike
3-Truck
4-Car");
            int choice = 0;
            //For taking valid choice
            do
            {
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid choice");
                }
            } while (choice <= 0 || choice > 4);
            Console.WriteLine();
            //For taking user choice
            switch(choice){
                case 1: Console.WriteLine("Bicycle moving status : " + Bicycle.isMoving());
                    Bicycle.Details();
                    Bicycle.safety();
                    break;
                case 2: Console.WriteLine("Bike moving status : " + Bike.isMoving());
                    Bike.Details();
                    Bike.safety();
                    break;
                case 3: Console.WriteLine("Truck moving status : " + Truck.isMoving());
                    Truck.Details();
                    Truck.safety();
                    break;
                case 4: Console.WriteLine("Car moving status : " + Car.isMoving());
                        Car.Details();
                        Car.safety();
                    break;
                default:
                    Console.WriteLine("Not exist");
                    break;

            }
             Console.ReadLine();
        }
    }
}
