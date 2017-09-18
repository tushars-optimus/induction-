using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_12_b_
{
    public class Vehicles
    {
        public float Rating { get; set; }
        public string CarName { get; set; }
        public string NamePlate { get; set; }
        public string Color { get; set; }

        public Vehicles(float Ratings,string CarNames,string NamePlates,string Colors)
        {
            Rating = Ratings;
            CarName = CarNames;
            NamePlate = NamePlates;
            Color = Colors;

        }
    }
}
