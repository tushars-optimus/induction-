using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvigilonProject.Model
{
    public class AvigilonModel
    {
        private string _alarm;

        public string Alarm
        {
            get { return _alarm; }
            set { _alarm = value; }
        }

        private string _site;

        public string Site
        {
            get { return _site; }
            set { _site = value; }
        }
        
        
    }
  
}
