using AvigilonProject.BuisnessLayer.Model;
using System.Collections.Generic;

namespace AvigilonProject.BuisnessLayer.Service
{
    /// <summary>
    /// To Read Alarm, Velocity  and Alarm mapping data 
    /// </summary>
    public interface IAvigilon
    {
        /// <summary>
        /// To read alarm data
        /// </summary>
        /// <returns>List of alarm data</returns>
        List<AlarmSite> ReadAvigilons();
        /// <summary>
        /// To read velocity data
        /// </summary>
        /// <returns>List of velocity data</returns>
        List<Velocity> ReadVelocity();
        /// <summary>
        /// To map Alarm and Velocity in Alarm Mapping model
        /// </summary>
        /// <param name="alarm"></param>
        /// <param name="site"></param>
        /// <param name="descriptioin"></param>
        void Selects(string alarm, string site, string descriptioin);
        /// <summary>
        /// To read alarm mapping data
        /// </summary>
        /// <returns>List of Alarm mapping data</returns>
        List<AvigilonMapping> ReadAlarmMapping();
        /// <summary>
        /// To Deselect alarm mapping data
        /// </summary>
        /// <param name="alarm"></param>
        /// <param name="descriptioin"></param>
        void Deletes(string alarm, string descriptioin);
    }
}
