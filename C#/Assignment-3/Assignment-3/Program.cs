using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    enum WeekDays { Sunday=1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    class TestEnum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sunday is:    {0}", (int)WeekDays.Sunday);
            Console.WriteLine("Monday is:    {0}", (int)WeekDays.Monday);
            Console.WriteLine("Tuesday is:   {0}", (int)WeekDays.Tuesday);
            Console.WriteLine("Wednesday is: {0}", (int)WeekDays.Wednesday);
            Console.WriteLine("Thursday is:  {0}", (int)WeekDays.Thursday);
            Console.WriteLine("Friday is:    {0}", (int)WeekDays.Friday);
            Console.WriteLine("Saturday is:  {0}", (int)WeekDays.Saturday);         
        }
    }
}
