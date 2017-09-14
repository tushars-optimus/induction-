using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class TestIf
    {
        private static string _choice;
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your preferred language");
            _choice = Console.ReadLine();
            if (_choice == "VB")
            {
                Console.WriteLine("VB .NET: OOP, multithreading and more!");
            }
            else if (_choice == "C#")
            {
                Console.WriteLine("Good choice, C# is a fine language.");
            }
            else
            {
                Console.WriteLine("Well...good luck with that!");
            }
            
        }
    }
}
