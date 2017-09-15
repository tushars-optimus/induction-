using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    
    class Program
    {
        static void Main(string[] args)
        {
            SchoolStudents[] Students_s = new SchoolStudents[3];
            Students_s[0] = new SchoolStudents("RAj", 19, "Science", "Bus");
            Students_s[0].Marks = 80;
            Students_s[1] = new SchoolStudents("Amit", 18, "Science", "Self");
            Students_s[1].Marks = 90;
            Students_s[2] = new SchoolStudents("Sharukh", 19, "Commerce", "Bus");
            Students_s[2].Marks = 85;
            CollegeStudents[] Students_c = new CollegeStudents[3];
            Students_c[0] = new CollegeStudents("RAj", 19, "Science", "Bus");
            Students_c[0].Marks = 90;
            Students_c[1] = new CollegeStudents("Amit", 18, "Science", "Self");
            Students_c[1].Marks = 74;
            Students_c[2] = new CollegeStudents("Sharukh", 19, "Commerce", "Bus");
            Students_s[2].Marks = 90;
            Console.WriteLine(@"Whose record would you like to see
1-School
2-College");
            int choice=0;
            //For taking Correct choice
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
            } while (choice <= 0 || choice > 2);

            Console.WriteLine();
            //Taking choice of the user
            switch(choice)
            {
                case 1: for (int i = 0; i < 3;i++ )
                    {
                        Console.Write(i+1+":");
                            Students_s[i].StudentsDetails();
                            Console.WriteLine();
                        }
                        break;
                case 2: for (int i = 0; i < 3; i++)
                        {
                            Students_c[i].StudentsDetails();
                            Console.WriteLine();
                        }
                        break;
                default: Console.WriteLine("Invalid Choice");
                        break;
            }
            Console.ReadLine();
        }
    }
}
