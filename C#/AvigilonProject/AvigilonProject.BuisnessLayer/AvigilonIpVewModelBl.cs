using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvigilonProject.DataAccess;
using AvigilonProject.BuisnessLayer.Model;

using System.Collections.ObjectModel;

namespace AvigilonProject.BuisnessLayer
{
    public class AvigilonIpVewModelBl : IAddIP
    {
        public AvigilonIpVewModelBl()
        {
            IpModel = new IpModelBl();
            IpModels = new ObservableCollection<IpModelBl>();
        }
        ProjectEntities ProjectEntities = new ProjectEntities();
        private IpModelBl _ipmodel;
        /// <summary>
        /// To interact with IpModelB 
        /// </summary>
        public IpModelBl IpModel
        {
            get 
            {
                return _ipmodel;
            }
            set
            {
                _ipmodel = value;
            }
        }
        private ObservableCollection<IpModelBl> _ipmodels;
        /// <summary>
        /// To store Ip model as a list
        /// </summary>
        public ObservableCollection<IpModelBl> IpModels
        {
            get
            {
                return _ipmodels;
            }
            set
            {
                _ipmodels = value;
            }
        }
        /// <summary>
        /// To read Ip value from database
        /// </summary>
        /// <returns> </returns>
        public virtual List<IpModelBl> ReadIp()
        {
            var description = ProjectEntities.Avigilon2.ToList();
            var IpModel = new List<IpModelBl>();
            foreach (var entity in description)
            {
                IpModel.Add(new IpModelBl
                {
                    IP = entity.IP,
                    Status=entity.Status,
                    Version=entity.Version
                });
            }

            return IpModel;
        } 
        /// <summary>
        /// To remove IP fom database
        /// </summary>
        /// <param name="ips"></param>
        public void RemoveIp(string ips)
        {
            var selecteditem = ProjectEntities.Avigilon2.Where(x => x.IP == ips).First();
            ProjectEntities.Avigilon2.Remove(selecteditem);
            ProjectEntities.SaveChanges();
        }
    }
}
