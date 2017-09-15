using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    
    class StudentDetails
    {
        public StudentDetails()
        {
            Names = new List<string>();
            Phones = new List<int>();
            Physics = new List<int>();
            Chemistrys = new List<int>();
            Maths = new List<int>();
        }
        
        public void AddNames(string Name)
        {
            Names.Add(Name);
        }
        public void AddPhone(int Phone)
        {
            Phones.Add(Phone);
        }
        public void AddPhysics(int Physic)
        {
            Physics.Add(Physic);
        }
        public void AddChemistry(int Chemistry)
        {
            Chemistrys.Add(Chemistry);
        }
        public void AddMaths(int Math)
        {
            Maths.Add(Math);
        }
        public statistics Computetatistics()
        {
            statistics stats = new statistics();
            for (int i = 0; i < Physics.Count;i++)
            {
                if (Physics[i] > stats.highestgradep)
                {
                    stats.highestgradep = Math.Max(Physics[i], stats.highestgradep);
                    stats.namep = Names[i];
                }
                if (Maths[i] > stats.highestgradem)
                {
                    stats.highestgradem = Math.Max(Maths[i], stats.highestgradem);
                    stats.namem = Names[i];
                }
                if (Chemistrys[i] > stats.highestgradec)
                {
                    stats.highestgradec = Math.Max(Chemistrys[i], stats.highestgradec);
                    stats.namec = Names[i];
                }
            }
            
             return stats;
        }
        List<int> Phones;
        List<string> Names;
        List<int> Physics;
        List<int> Chemistrys;
        List<int> Maths;
    }
}
