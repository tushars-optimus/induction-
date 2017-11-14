using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    public enum Attribute
    {
        Name=1,Address,Age,Phone
        
    };
    class Student
    {
        
        static void Main(string[] args)
        {
            StudentDetail[] student= new StudentDetail[3];
            student[0] = new StudentDetail("Dilip", "New Delhi", 24, 98786234);
            student[1] = new StudentDetail("Raj", "New Delhi", 27, 98736514);
            student[2] = new StudentDetail("AAkansh", "Dwarka", 20, 98746454);
            Console.WriteLine("Welcome students");
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                student[i].ShowDetail();
            }
            Console.WriteLine(@"what do you want to see
1-Name 2-Address 3-age, 4-phone");
             
            
            int _choice = int.Parse(Console.ReadLine());

            switch (_choice)
            {
                case 1: for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine(student[i].Name);
                    }
                    break;
                case 2: for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine(student[i].Address);
                    }
                    break;
                case 3: for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine(student[i].Age);
                    }
                    break;
                case 4: for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine(student[i].Phone);
                    }
                    break;
                default:
                    Console.WriteLine("Not found");
                    break;

            }
            Console.ReadLine();
        }

            }
}
