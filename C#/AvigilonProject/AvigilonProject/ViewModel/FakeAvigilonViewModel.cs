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
    public class FakeAvigilonViewModel : IAvigilon
    {
        public List<BuisnessLayer.Model.AlarmSite> ReadAvigilons()
        {
            throw new NotImplementedException();
        }

        public List<BuisnessLayer.Model.Velocity> ReadVelocity()
        {
            throw new NotImplementedException();
        }
        private bool _flags;

        public bool Flags
        {
            get { return _flags; }
            set { _flags = value; }
        }

        private bool _flagd;

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
    }
}
