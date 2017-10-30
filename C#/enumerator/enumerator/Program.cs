using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumerator
{
    class players
    {
        public string name { get; set; }
        public int age { get; set; }
        public players(string n1,int ag)
        {
            name = n1;
            age = ag;
                
        }
    }
    class team:IEnumerable
    {
        private players[] personarray = new players[3];
        public team ()
	{
        personarray[0] = new players ( "virat", 30 );
        personarray[1] = new players ( "dhoni", 29 );
        personarray[2] = new players ( "Sachin", 38 );
	}

        public IEnumerator GetEnumerator()
        {
            return personarray.GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            team obj = new team();
          
          foreach (players player in obj)
          {
              Console.WriteLine(player.name+" "+player.age);
          }
          Console.ReadLine();
        }
    }
}
