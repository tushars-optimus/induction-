using System.Collections.Generic;
using System.Linq;
using AvigilonProject.DataAccess;
using AvigilonProject.BuisnessLayer.Model;

using System.Collections.ObjectModel;

namespace AvigilonProject.BuisnessLayer.Service
{
    public class AvigilonIpVewModels : IAddIP
    {
        public AvigilonIpVewModels()
        {
            IpModel = new IpModelBl();
            IpModels = new ObservableCollection<IpModelBl>();
        }
        ProjectEntities _projectentities = new ProjectEntities();
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
            var ipDescription = _projectentities.Avigilon2.ToList();
            var IpModel = new List<IpModelBl>();
            foreach (var entity in ipDescription)
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
            var selectedItem = _projectentities.Avigilon2.Where(x => x.IP == ips).FirstOrDefault();
            
            _projectentities.Avigilon2.Remove(selectedItem);
            _projectentities.SaveChanges();
        }
    }
}
