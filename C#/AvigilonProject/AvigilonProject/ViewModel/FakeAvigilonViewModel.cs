using AvigilonProject.BuisnessLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvigilonProject.BuisnessLayer.Model;
using AvigilonProject.BuisnessLayer;

namespace AvigilonProject.ViewModel
{
    public class FakeAvigilonViewModel : IAvigilon,IAddIP
    {
        #region Private Region
        private bool _flags;
        private bool _flagd;
        private bool _flagIp;
        #endregion

        public List<BuisnessLayer.Model.AlarmSite> ReadAvigilons()
        {
            throw new NotImplementedException();
        }

        public List<BuisnessLayer.Model.Velocity> ReadVelocity()
        {
            throw new NotImplementedException();
        }
        
        public bool Flags
        {
            get { return _flags; }
            set { _flags = value; }
        }

        

        public bool Flagd
        {
            get { return _flagd; }
            set { _flagd = value; }
        }
        public void Selects(string alarm, string site, string descriptioin)
        {
            
                var projectentities = new AvigilonMapping { Alarm = alarm, Site = site, Description = descriptioin };
                
                if (projectentities == null)
                {
                    _flags = false;
                }
                else
                {
                    _flags = true;
                    
                }
            
        }

        public List<BuisnessLayer.Model.AvigilonMapping> ReadAlarmMapping()
        {
            throw new NotImplementedException();
        }

        public void Deletes(string alarm, string descriptioin)
        {
            if(alarm==""|| descriptioin=="")
            {
                Flagd = false;
            }
            else
            {
                Flagd = true;
            }
        }

        public List<IpModelBl> ReadIp()
        {
            throw new NotImplementedException();
        }
        

        public bool FLagIp
        {
            get { return _flagIp; }
            set { _flagIp = value; }
        }
        
        public void RemoveIp(string ips)
        {
            switch(ips)
            {
                case "1.1.1.1": FLagIp = true;
                    break;
                case "1.2.3.4": FLagIp = true;
                    break;
                default: FLagIp = false;
                    break;

            }
        }
    }
}
