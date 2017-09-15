using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    class CollegeStudents : Students
    {
        public float Marks; 
        public CollegeStudents(string name, int age, string field, string vehicle)
        {
            _name = name;
            _age = age;
            _branch = field;
            _vehicle=vehicle;

        }
        public void StudentsDetails()
        {
            Console.WriteLine("Name {0}", _name);
            Console.WriteLine("Education : College ");
            Console.WriteLine("Age {0}", _age);
            Console.WriteLine("Field {0}", _branch);
            Console.WriteLine("Marks in previous Session {0}", Marks);
            Console.WriteLine("Vehicle {0}", _vehicle);
            
        }

    }
}
