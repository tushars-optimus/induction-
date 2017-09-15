using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class TestStrings
    {
        static public string[] GetStringArray()
        {
            string[] s1 = { "Monday", "Tuesday", "Wednesday","Thursday", "Friday", "Saturday", "Sunday" };
            return s1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Weeks are ");
            string[] s1=new string[7];
            s1 = GetStringArray();
            foreach(string week in s1)
            {
                Console.WriteLine(week);
            }
            

        }
    }
}
