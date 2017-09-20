using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsNLists2
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public Vehicle(string name, string color)
        {
            Name = name;
            Color = color;
        }
    
        public override string ToString()
        {
            return "\nName: " + Name + "\nColor: " + Color;
        }
    }
}
