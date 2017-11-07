using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_21
{
    public class StudentDatabaseContext:DbContext
    {
        public StudentDatabaseContext():base("name=Assignment")
        {

        }
        public  DbSet<StudentDb> StudentDbs { get; set; }
    }
}
