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
            Car car=new Car();
            Truck truck=new Truck();
            Bike bike=new Bike();
            Bicycle bicycle=new Bicycle();
            car.Accelerate(50);
            truck.Accelerate(40);
            bicycle.Accelerate(30);
            bicycle.Deaccelarate(10);
            
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
                case 1: Console.WriteLine("Bicycle moving status : " + bicycle.isMoving());
                    bicycle.Details();
                    bicycle.Safety();
                    break;
                case 2: Console.WriteLine("Bike moving status : " + bike.isMoving());
                    bike.Details();
                    bike.Safety();
                    break;
                case 3: Console.WriteLine("Truck moving status : " + truck.isMoving());
                    truck.Details();
                    truck.Safety();
                    break;
                case 4: Console.WriteLine("Car moving status : " + car.isMoving());
                        car.Details();
                        car.Safety();
                    break;
                default:
                    Console.WriteLine("Not exist");
                    break;

            }
             Console.ReadLine();
        }
    }
}
