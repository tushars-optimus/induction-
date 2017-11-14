using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class TestStrings
    {
        static public string[] GetWeekDays()
        {
            string[] WeekDays = { "Monday", "Tuesday", "Wednesday","Thursday", "Friday", "Saturday", "Sunday" };
            return WeekDays;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Weeks are ");
            Console.WriteLine();
            string[] WeekDays = new string[7];
            WeekDays = GetWeekDays();
            foreach (string days in WeekDays)
            {
                Console.WriteLine(days);
            }
            Console.ReadLine();
            

        }
    }
}
