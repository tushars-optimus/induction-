using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvigilonProject.BuisnessLayer.Model
{
    public class IpModelBl
    {
        private string _ip;
        private string _version;
        private string _status;

        public string IP
        {
            get { return _ip; }
            set { _ip = value; }
        }
        

        public string Version
        {
            get { return _version; }
            set { _version = value; }
        }
               

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        
        
        
    }
}
