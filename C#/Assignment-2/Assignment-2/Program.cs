using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class TestSwitch
    {
        private static string _choice;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your preferred language");
            _choice = Console.ReadLine();
            switch(_choice)
            {
                case "VB":
                    Console.WriteLine("VB .NET: OOP, multithreading and more!");
                    break;
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
            

        }
    }
}
