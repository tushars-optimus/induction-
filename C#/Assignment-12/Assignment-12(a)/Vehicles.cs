using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_12_a_
{
    class Vehicles:IComparable<Vehicles>
    {
        public float Rating { get; set; }
        public string CarName { get; set; }
        public string NamePlate { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {

            return "\nRating: " + Rating + "\nCarName: " + CarName + "\nColor: " + Color + "\nNamePlate: " + NamePlate;
            
        }

        public int CompareTo(Vehicles obj)
        {
            if (this.Rating > obj.Rating)
                return -1;
            else if (this.Rating < obj.Rating)
                return 1;
            else
                return 0;
        }
        public override bool Equals(object obj1)
        {
            if (obj1 == null)
            {
                return false;
            }

            return this.Rating == ((Vehicles)obj1).Rating && this.NamePlate == ((Vehicles)obj1).NamePlate && this.Color == ((Vehicles)obj1).Color && this.CarName == ((Vehicles)obj1).CarName;
        }
             
    }
}
