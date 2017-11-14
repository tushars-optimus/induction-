using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    public class StudentDetail : StudentsDetail
    {
        private string _name, _address;
        private int _id, _age, _phone;
        //using constructor to take values
        public StudentDetail(string name, String address, int age, int phone)
        {
            _name = name;
            _age = age;
            _phone = phone;
            _address = address;
            Random rnd = new Random();
            _id = rnd.Next(100);
        }
        //overload of StudentDetail
        public StudentDetail()
        {
            _name = null;
            _age = 0;
            _phone = 0;
            _address = null;
            Random rnd = new Random();
            _id = 0;
        }
        //To show details of student 
        public override void ShowDetail()
        {
            Console.WriteLine("ID" + " " + _id);
            Console.WriteLine("Name:" + " " + _name);
            Console.WriteLine("Address" + " " + _address);
            Console.WriteLine("Age:" + " " + _age);
            Console.WriteLine("phone" + " " + _phone);
            Console.WriteLine();
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
        }
        public int Phone
        {
            get
            {
                return _phone;
            }
        }
    }
}
