using System.Collections.Generic;
using System.Linq;
using AvigilonProject.DataAccess;
using AvigilonProject.BuisnessLayer.Model;
using AvigilonProject.BuisnessLayer.Service;

namespace AvigilonProject.BuisnessLayer
{
    public class AvigilonProjecyBl : IAvigilon
    {
        //TODO: add access specifier, naming convention
        ProjectEntities _projectentities = new ProjectEntities();
        /// <summary>
        /// To read values from database
        /// </summary>
        /// <returns>AvigilonModel</returns>
        public virtual List<AlarmSite> ReadAvigilons()
        {
            
            var alarmSites = _projectentities.Avigilons.ToList();
            var avigilonModel = new List<AlarmSite>();
            foreach (var entity in alarmSites)
            {
                avigilonModel.Add(new AlarmSite
                {
                    Alarm = entity.Alarm,
                    Site=entity.Sites
                });
            }

            return avigilonModel;
        }
        /// <summary>
        /// To read value from Velocity
        /// </summary>
        /// <returns>VelocityModel</returns>
        public virtual List<Velocity> ReadVelocity()
        {
            var description = _projectentities.Alarm_Description.ToList();
            var velocityModel = new List<Velocity>();
            foreach (var entity in description)
            {
                velocityModel.Add(new Velocity
                {
                    Description = entity.Descriptions
                });
            }

            return velocityModel;
        } 
        /// <summary>
        /// To map Alarm and Velocity in Alarm Mapping model
        /// </summary>
        /// <param name="alarm"></param>
        /// <param name="site"></param>
        /// <param name="descriptioin"></param>
        public void Selects(string alarm,string site,string descriptioin)
        {
            var projectentities = new AlarmMapping { Alarm = alarm, Sites = site, Descriptions = descriptioin };
            _projectentities.AlarmMappings.Add(projectentities);
            _projectentities.SaveChanges();
        }
        /// <summary>
        /// To read Alarm Mapping model
        /// </summary>
        /// <returns>AlarmMapping</returns>
        public virtual List<AvigilonMapping> ReadAlarmMapping()
        {
            var alarmMaps = _projectentities.AlarmMappings.ToList();;
            var alarmMapppingBl = new List<AvigilonMapping>();
            foreach (var entity in alarmMaps)
            {
                alarmMapppingBl.Add(new AvigilonMapping
                {
                    Alarm=entity.Alarm,
                    Site = entity.Sites,
                    Description = entity.Descriptions
                });
            }

            return alarmMapppingBl;
        }

        /// <summary>
        /// Method to delete alarm mapping
        /// </summary>
        /// <param name="alarm">Alarm</param>
        /// <param name="descriptioin">Description</param>
        public void Deletes(string alarm, string descriptioin)
        {

            var del = _projectentities.AlarmMappings.Where(x => x.Alarm == alarm && x.Descriptions==descriptioin).First();
            _projectentities.AlarmMappings.Remove(del);
            _projectentities.SaveChanges();
        }
    }
}
