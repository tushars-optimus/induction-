using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14
{
    public class Vehicle:IComparable<Vehicle>,IEquatable<Vehicle>
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Tyres { get; set; }
        public Vehicle(string name, string color, int tyre)
        {
            Name = name;
            Color = color;
            Tyres=tyre;
        }

        // To arrange tyre in Ascending order 

        public int CompareTo(Vehicle other)
        {

            if (this.Tyres > other.Tyres)
            {
                return 1;
            }
            else if (this.Tyres < other.Tyres)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        
        ////To compare vehicle Name Alphabeticcaly Ascending

        //public int CompareTo(Vehicle other)
        //{
        //    int result = other.Name.CompareTo(this.Name);
        //     return result;
        //}

        ////To compare vehicle Name Alphabeticcaly Desending
        //public int CompareTo(Vehicle other)
        //{
        //    int result = this.Name.CompareTo(other.Name);
        //    return result;
        //}

        public bool Equals(Vehicle other)
        {
            if (this.Name == other.Name)
            {
                return true;
            }
            else
                return false;
        }

        public override string ToString()
        {
            return "Vehicle name is: " + Name + "\nVehicle color is: " + Color + "\nNumber of tyres is: " + Tyres;
        }
    }
}
