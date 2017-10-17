using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvigilonProject.DataAccess;
using System.Collections.ObjectModel;

using AvigilonProject.BuisnessLayer.Model;
using AvigilonProject.Model;

namespace AvigilonProject.BuisnessLayer
{
    public class AvigilonProjecyBl
    {
        ProjectEntities ProjectEntities = new ProjectEntities();
        /// <summary>
        /// To read values from database
        /// </summary>
        /// <returns>AvigilonModel</returns>
        public List<Avigilons> ReadAvigilons()
        {
            var Cameras = ProjectEntities.Avigilons.ToList();
            var AvigilonModel = new List<Avigilons>();
            foreach (var entity in Cameras)
            {
                AvigilonModel.Add(new Avigilons
                {
                    Alarm = entity.Alarm,
                    Site=entity.Sites
                });
            }

            return AvigilonModel;
        }
        /// <summary>
        /// To read value from Velocity
        /// </summary>
        /// <returns>VelocityModel</returns>
        public List<Velocity> ReadVelocity()
        {
            var description = ProjectEntities.Alarm_Description.ToList();
            var VelocityModel = new List<Velocity>();
            foreach (var entity in description)
            {
                VelocityModel.Add(new Velocity
                {
                    Description = entity.Descriptions
                });
            }

            return VelocityModel;
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
            ProjectEntities.AlarmMappings.Add(projectentities);
            ProjectEntities.SaveChanges();
        }
        /// <summary>
        /// To read Alarm Mapping model
        /// </summary>
        /// <returns>AlarmMapping</returns>
        public List<AlarmMappingBl> ReadAlarmMapping()
        {
            var alarmMaps = ProjectEntities.AlarmMappings.ToList();;
            var alarmMapppingBl = new List<AlarmMappingBl>();
            foreach (var entity in alarmMaps)
            {
                alarmMapppingBl.Add(new AlarmMappingBl
                {
                    AlarmBl=entity.Alarm,
                    SiteBl = entity.Sites,
                    DescriptionBl = entity.Descriptions
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

            var del = ProjectEntities.AlarmMappings.Where(x => x.Alarm == alarm && x.Descriptions==descriptioin).First();
            ProjectEntities.AlarmMappings.Remove(del);
            ProjectEntities.SaveChanges();
        }
    }
}
