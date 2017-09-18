using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_12_b_
{
    class AddVehicle:IEnumerable
    {
        Vehicles [] vehicle  = new Vehicles[4];

        public AddVehicle()
	        {
                vehicle[0]=new Vehicles(4.5f,"Honda City","DL 2g 7131","Black");
                vehicle[1]=new Vehicles(4.4f,"Maruti","DL 5g 7437","Red");
                vehicle[2]=new Vehicles(4.9f,"Crata","UP 5g 7631","Yellow");
                vehicle[3] = new Vehicles(3.9f, "Waganar", "MP 9m 7631", "Pink");
	        
            }
    
public IEnumerator GetEnumerator()
{
    return vehicle.GetEnumerator();
}
}
}
