using AvigilonProject.BuisnessLayer.Model;
using System.Collections.Generic;

namespace AvigilonProject.BuisnessLayer.Service
{
    /// <summary>
    /// Manages operations on IP
    /// </summary>
    public interface IAddIP
    {
        /// <summary>
        /// Method to read Ip
        /// </summary>
        /// <returns>List of Ip</returns>
        List<IpModelBl> ReadIp();

        /// <summary>
        /// Method to remove Ip
        /// </summary>
        /// <param name="ips"></param>
        void RemoveIp(string ips);
    }
}
