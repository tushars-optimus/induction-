using System;
using System.Linq;
using AvigilonProject.DataAccess;

namespace AvigilonProject.BuisnessLayer.Service
{
    public class AvigilonAddIp
    {
        const string status = "Ready";
        const string Versions = "6.0.0.24";
        public EventHandler OperationInvalid;
        ProjectEntities _projectenties = new ProjectEntities();
        /// <summary>
        /// To save new IP address in Database
        /// </summary>
        /// <param name="ip"></param>
        public void Save(string ip)
        {
            int flag = 1;
            string[] ips = ip.Split('.');
            foreach (string item in ips)
            {
                try
                {
                    int number = int.Parse(item);
                    if (((number > 255) && (number < 0)) || (ips.Count() != 4))
                    {
                        throw new Invalid();
                    }

                }
                catch (FormatException)
                {
                    flag = 0;
                    OnWorkCompleted();
                }
                catch (Invalid)
                {
                    flag = 0;
                    OnWorkCompleted();
                }
            }
            if (flag == 1)
            {
                var entities = new Avigilon2 { IP = ip, Status = status, Version = Versions };
                var existingIp = _projectenties.Avigilon2.Where(p => p.IP == ip).ToList();
                if (existingIp.Count==0)
                {

                    _projectenties.Avigilon2.Add(entities);
                    _projectenties.SaveChanges();
                }
            }
        }
        /// <summary>
        /// To create event for Invalid ip
        /// </summary>
            protected virtual void OnWorkCompleted()
            {
             if (OperationInvalid != null)
                {
                 OperationInvalid(this, (EventArgs.Empty));
                 }
             }
    }
}