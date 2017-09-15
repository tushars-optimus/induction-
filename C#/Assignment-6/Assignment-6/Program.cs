using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Student
    {
        static void Main(string[] args)
        {
            statistics show1 = new statistics();
            StudentDetails stats1 = new StudentDetails();
            //Details for 1st Person
            stats1.AddNames("Tushar");
            stats1.AddPhone(005830393);
            stats1.AddMaths(85);
            stats1.AddPhysics(80);
            stats1.AddChemistry(70);
            //Details for 2nd Person
            stats1.AddNames("Rahul");
            stats1.AddPhone(002830393);
            stats1.AddMaths(83);
            stats1.AddPhysics(90);
            stats1.AddChemistry(50);
            //Details for 3rd Person
            stats1.AddNames("Raj");
            stats1.AddPhone(505830393);
            stats1.AddMaths(75);
            stats1.AddPhysics(89);
            stats1.AddChemistry(79);
            //Details for 4th Person
            stats1.AddNames("Mohit");
            stats1.AddPhone(005838393);
            stats1.AddMaths(96);
            stats1.AddPhysics(77);
            stats1.AddChemistry(74);
            //Calculating highest marks
            show1 = stats1.Computetatistics();
            Console.WriteLine(show1.namem+" : "+show1.highestgradem);
            Console.WriteLine(show1.namep + " : " + show1.highestgradep);
            Console.WriteLine(show1.namec + " : " + show1.highestgradec);
            Console.ReadLine();
        }
    }
}
