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
            statistics ShowStudent = new statistics();
            StudentDetails StatsStudent = new StudentDetails();
            //Details for 1st Person
            StatsStudent.AddNames("Tushar");
            StatsStudent.AddPhone(005830393);
            StatsStudent.AddMaths(85);
            StatsStudent.AddPhysics(80);
            StatsStudent.AddChemistry(70);
            //Details for 2nd Person
            StatsStudent.AddNames("Rahul");
            StatsStudent.AddPhone(002830393);
            StatsStudent.AddMaths(83);
            StatsStudent.AddPhysics(90);
            StatsStudent.AddChemistry(50);
            //Details for 3rd Person
            StatsStudent.AddNames("Raj");
            StatsStudent.AddPhone(505830393);
            StatsStudent.AddMaths(75);
            StatsStudent.AddPhysics(89);
            StatsStudent.AddChemistry(79);
            //Details for 4th Person
            StatsStudent.AddNames("Mohit");
            StatsStudent.AddPhone(005838393);
            StatsStudent.AddMaths(96);
            StatsStudent.AddPhysics(77);
            StatsStudent.AddChemistry(74);
            //Calculating highest marks
            ShowStudent = StatsStudent.Computetatistics();
            Console.WriteLine(ShowStudent.Namem + " : " + ShowStudent.HghestGradem);
            Console.WriteLine(ShowStudent.Namep + " : " + ShowStudent.HighestGradep);
            Console.WriteLine(ShowStudent.Namec + " : " + ShowStudent.HighestGradec);
            Console.ReadLine();
        }
    }
}
