
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvigilonProject.BuisnessLayer.Model
{
    public interface IAvigilonBl
    {
        List<AlarmSite> ReadAvigilons();
        List<Velocity> ReadVelocity();
        void Selects(string alarm, string site, string descriptioin);
        List<AlarmMappingBl> ReadAlarmMapping();
        void Deletes(string alarm, string descriptioin);
    }
}
